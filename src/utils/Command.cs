﻿using DevExpress.Utils.DirectXPaint;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BankReplication;
using BankReplication.utils;
// Author: trung-kieen

/*
 * Help to perform undo and redo action on gridview by perform data change on BindingSource object
 * Most of command is flexible to reuse in any data load from BindingSource to gridview
 * But all command here use BindingSourceExtends, an extends from BindingSource class 
 * with helper method to reduce boilerplate code
 */
namespace BankReplication.utils
{

    // The Command interface declares a method for executing a command and feature undo and redo.
    public interface ICommand
    {
        void Execute();
        void Undo();

        Boolean ReadyUndo();
        void Redo();
    }

    class AddCommand : ICommand
    {
        private BankReplication.utils.BindingSourceExtends _bds;
        private DataRowView _rowView;
        private object[] _rows;
        private int originPosition;
        private Action _reload;
        private Action _save;
        public Boolean ReadyUndo()
        {
            return true;
        }
        public AddCommand(BankReplication.utils.BindingSourceExtends bds, object[] rows, Action reload, Action save)
        {
            _bds = bds;
            _rows = rows;
            originPosition = _bds.Position;
            _reload = reload;
            _save = save;

        }
        public AddCommand(BankReplication.utils.BindingSourceExtends bds, DataRowView rowView, Action reload, Action save)
        {
            _bds = bds;
            _rows = ModelMapper.RowViewToRowList(rowView);
            _rowView = rowView;
            originPosition = _bds.Position;
            _reload = reload;
            _save = save;
        }
        public void Execute()
        {
            bool bdsNotContainNewRow = _bds.IndexOf(_rows) == -1;
            if (bdsNotContainNewRow)
            {
                _rowView = (DataRowView)_bds.AddNew();
                _rowView.BeginEdit();
                _rowView.Row.ItemArray = _rows;
                _rowView.EndEdit();

            }
            _bds.EndEdit();
            _save();
            _reload();
            _bds.Focus(_rows);

        }
        public void Undo()
        {
            _bds.Focus(_rows);
            _bds.RemoveRow(_rows);
            _bds.EndEdit();
            _save();
        }
        public void Redo()
        {
            this.Execute();
        }

    }

    class DeleteCommand : ICommand
    {
        private BankReplication.utils.BindingSourceExtends _bds;
        private DataRowView _rowView;
        private object[] _rows;
        private int originPosition;
        private Action _reload;
        private Action _save;
        public DeleteCommand(BankReplication.utils.BindingSourceExtends bds, DataRowView rowView, Action reload, Action save)
        {
            _rowView = rowView;
            _bds = bds;
            originPosition = _bds.Position;
            _reload = reload;
            _save = save;
        }
        public Boolean ReadyUndo()
        {
            return true;
        }
        public void Execute()
        {
            if (_bds.Count > 0)
            {
                _rows = ModelMapper.RowViewToRowList(_rowView);
                _bds.Focus(_rows);
                _bds.RemoveCurrent();
                _bds.EndEdit();
                _save();


            }
        }
        public void Undo()
        {
            bool bdsNotContainNewRow = _bds.IndexOf(_rows) == -1;
            if (bdsNotContainNewRow)
            {
                _rowView = (DataRowView)_bds.AddNew();
                _rowView.BeginEdit();
                _rowView.Row.ItemArray = _rows;
                _rowView.EndEdit();

            }
            _bds.EndEdit();
            _save();
            _bds.Focus(_rows);

        }
        public void Redo()
        {
            // Same with execute but not change postion
            int originPosition = _bds.Position;
            this.Execute();
            _bds.Position = originPosition;

        }

    }
    class EditCommand : ICommand
    {
        private BankReplication.utils.BindingSourceExtends _bds;
        private DataRowView _rowView;
        private object[] _before;
        private object[] _after;
        private Action _save;
        public EditCommand(BankReplication.utils.BindingSourceExtends bds, Action save)
        {
            _bds = bds;
            _before = ModelMapper.RowViewToRowList((DataRowView)_bds.Current);
            _bds.EndEdit();
            _after = ModelMapper.RowViewToRowList((DataRowView)_bds.Current);
            _rowView = (DataRowView)_bds.Current;
            _save = save;
        }
        public EditCommand(BankReplication.utils.BindingSourceExtends bds, object[] before, object[] after, Action save)
        {
            _bds = bds;
            _before = before;
            _bds.EndEdit();
            _after = after;
            _rowView = (DataRowView)_bds.Current;
            _save = save;
        }
        public Boolean ReadyUndo()
        {
            return true;
        }
        public void Execute()
        {

            _bds.Update(_before, _after);
            _bds.EndEdit();
            _save();
        }
        public void Undo()
        {
            _bds.Update(_after, _before);
            _bds.Focus(_before);
            _bds.EndEdit();
            _save();
        }
        public void Redo()
        {
            _bds.Update(_before, _after);
            _bds.Focus(_after);
            _bds.EndEdit();
            _save();
        }

    }
    class PositionCommand : ICommand
    {
        int pos;
        BindingSource _bds;
        public PositionCommand(BindingSource bds)
        {

            _bds = bds;

        }

        public void Execute()
        {
            pos = _bds.Position;
        }

        public Boolean ReadyUndo()
        {
            return true;
        }
        public void Undo()
        {
            _bds.Position = pos;
        }
        public void Redo()
        {
            _bds.Position = pos;

        }
    }
    class ChuyenCNCommand : ICommand
    {
        private BindingSourceExtends _bds;
        private String _connString;
        private String _remote_connString;
        private String _maNVCu;
        private String _maNVMoi;
        private String _maCNCu;
        private String _maCNMoi;
        private Action _reload;
//        private String _role;
        public ChuyenCNCommand(BindingSourceExtends bds, String connString, String remote_connString, String maNVCu, String maNVMoi, String maCNCu, String maCNMoi, Action reload)
        {
            _bds = bds;
            _connString = connString;
            _remote_connString = remote_connString;
            _maNVCu = maNVCu;
            _maNVMoi = maNVMoi;
            _maCNCu = maCNCu;
            _maCNMoi = maCNMoi;
            _reload = reload;

        }
        public void Execute()
        {
            int position = _bds.Position;
            Program.conn.Close();
            Program.conn.ConnectionString = _connString;
            if (Program.KetNoi(Database.Connection.NotShowError) == Database.Connection.Fail)
            {
                Msg.Error("Không thể kết nối tới máy chủ");
                return;
            }


            // TODO: manager role 
            /*
            try {
                // Not allow old employee access database 
                _role = Program.ExecSqlScalar("EXEC SP_DropEmployeeRole '" + _maNVCu + "'");
            }
            catch
            {
            }
            */

            try
            {
                String SPName = "SP_ChuyenNhanVien";
                String cmd = $"EXEC {SPName} "
                    + $"  '{_maNVCu}' "
                    + $", '{_maNVMoi}' "
                    + $", '{_maCNCu}' "
                    + $", '{_maCNMoi}' ";

                Program.ExecSqlNonQuery(cmd);

                _reload();

                Msg.Info("Nhân viên đã được chuyển qua chi nhánh mới với mã nhân viên là " + _maNVMoi);

            }
            catch (Exception ex)
            {
                Msg.Error("Lỗi khi chuyển nhân viên\n" + ex.Message, "Thao tác không thành công");

            }


            if (_bds.Find("MANV", _maNVCu) > 0)
                _bds.Position = _bds.Find("MANV", _maNVCu);
            else
                _bds.Position = position;

        }
        // Avoid error from slow synchronize when use distribute transaction
        public Boolean ReadyUndo()
        {
            Program.conn.Close();
            Program.conn.ConnectionString = _connString;
            Program.conn.ConnectionString = _remote_connString;
            try
            {
                String NewEmployeeId= Program.ExecSqlScalar($"SELECT MANV FROM NGANHANG.dbo.NhanVien WHERE MANV = '{_maNVMoi}'" );
                if (NewEmployeeId.Trim() != _maNVMoi)
                    throw new Exception("Not match");
            }
            catch (Exception ex)
            {
                Msg.Error("Chưa thể hoàn tác thao tác chuyển nhân viên do dữ liệu chưa đồng bộ vui lòng chờ ít phút");
                Program.conn.Close();
                Program.conn.ConnectionString = _connString;
                return false;

            }

            Program.conn.Close();
            Program.conn.ConnectionString = _connString;
            return true;
        }
        public void Undo()
        {
            Program.conn.Close();
            Program.conn.ConnectionString = _connString;
            Program.conn.ConnectionString = _remote_connString;
            try
            {
                int pos = _bds.Position;

                String oldBranch = Program.ExecSqlScalar("SELECT MACN FROM NGANHANG.dbo.ChiNhanh");
                String SPName = "SP_ChuyenNhanVien";
                String cmd = $"EXEC {SPName} "
                    + $"  '{_maNVMoi}' "
                    + $", '{_maNVCu}' "
                    + $", '{_maCNMoi}' "
                    + $", '{_maCNCu}' ";

                Program.ExecSqlNonQuery(cmd);
                _reload();

                Msg.Info($"Nhân viên đã được chuyển từ chi nhánh {oldBranch} về lại chi nhánh ban đầu với mã nhân viên là {_maNVCu}. Vui lòng chờ ít phút để dữ liệu cập nhập đầy đủ");
                pos = _bds.Position;
                if (_bds.Find("MANV", _maNVCu) > 0)
                    pos = _bds.Find("MANV", _maNVCu);

            }
            catch (Exception ex)
            {
                Msg.Error("Lỗi khi chuyển nhân viên\n" + ex.Message, "Thao tác không thành công");

            }

            Program.conn.Close();
            Program.conn.ConnectionString = _connString;
        }

        public void Redo()
        {
            this.Execute();

        }

    }

    // The Invoker is associated with one or several commands. It sends a
    // request to the command.
    public class Invoker
    {
        private Stack<ICommand> undoStack;
        private Stack<ICommand> redoStack;

        public Invoker()
        {
            undoStack = new Stack<ICommand>();
            redoStack = new Stack<ICommand>();
        }

        public void Execute(ICommand command)
        {
            try
            {
                command.Execute();
                redoStack.Clear();
                undoStack.Push(command);
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message, "Thao tác không thành công");
            }
        }

        public void Undo()
        {

            try
            {
                if (undoStack.Count > 0)
                {
                    ICommand cmd = undoStack.Pop();
                    if (cmd.ReadyUndo())
                    {
                    cmd.Undo();
                    }
                    else
                    {
                        undoStack.Push(cmd);
                        return; 
                    }
                    redoStack.Push(cmd);
                }
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message, "Thao tác không thành công");
            }
        }

        public void Redo()
        {
            try
            {
                if (redoStack.Count > 0)
                {
                    ICommand cmd = redoStack.Pop();
                    cmd.Redo();
                    undoStack.Push(cmd);
                }
            }
            catch (Exception ex)
            {
                Msg.Error(ex.Message, "Thao tác không thành công");
            }
        }
        public Boolean Redoable()
        {
            return redoStack.Count > 0;
        }

        public Boolean Undoable()
        {
            return undoStack.Count > 0;
        }

    }


    public class ModelMapper
    {
        public static object[] RowViewToRowList(DataRowView rowView)
        {
            return rowView.Row.ItemArray.Clone() as object[];
        }

    }



}