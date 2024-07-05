using QLQuanAn.DTO;
using System;
using System.Data;

namespace QLQuanAn.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO()
        {

        }
        // thành công: bill ID
        // thất bại : -1 
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id + "AND status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }

        public void CheckOut(int id, int discount, float totalPrice)
        {
            string query = "UPDATE dbo.Bill SET DateCheckOut = GETDATE(), status = 1, " + "discount = " + discount + ", totalPrice =" + totalPrice + " WHERE id = " + id;
            DataProvider.Instance.ExcuteNonQuery(query);
            //string query2 = "UPDATE dbo.Bill SET DateCheckOut = GETDATE() WHERE id = " + id;
            //DataProvider.Instance.ExcuteNonQuery(query2);
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("EXEC USP_InsertBill @idTable", new object[] { id });
        }

        public DataTable GetBillLListByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExcuteQuery("EXEC USP_GetListBillByDay @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        public DataTable GetBillLListByDateAdndPage(DateTime checkIn, DateTime checkOut, int pageNumber)
        {
            return DataProvider.Instance.ExcuteQuery("EXEC USP_GetListBillByDayAndPage @checkIn , @checkOut , @page", new object[] { checkIn, checkOut, pageNumber });
        }
        public int GetNumBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return (int)DataProvider.Instance.ExcuteScalar("EXEC USP_GetNumBillByDay @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        public int GetmaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }

        public void DeleteBillByIDTable(int idTable)
        {
            string query1 = string.Format("DELETE BillInfo WHERE idBill IN (SELECT id FROM dbo.Bill WHERE idTable = {0})", idTable);
            DataProvider.Instance.ExcuteQuery(query1);

            string query2 = string.Format("DELETE Bill WHERE idTable = {0}", idTable);
            DataProvider.Instance.ExcuteQuery(query2);
        }
    }
}

