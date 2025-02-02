﻿using QLQuanAn.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLQuanAn.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "SELECT * FROM Food WHERE idCategory = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            string query = "SELECT * FROM Food";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();

            string query = string.Format("SELECT * FROM dbo.Food WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public bool InsertFood(string name, int id, float price)
        {
            string query = string.Format("INSERT dbo.Food (name, idCategory, price) VALUES (N'{0}', {1}, {2} )", name, id, price);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFood(int idFood, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.Food SET name = N'{0}', idCategory = (1), price = {2} WHERE id = {3}", name, id, price, idFood);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFood(int idFood)
        {
            BillInfoDAO.Instance.DeleteBillInfoByFood(idFood);

            string query = string.Format("DELETE Food WHERE id = {0}", idFood);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public void DeleteFoodByIDCategory(int idCategory)
        {
            string query1 = string.Format("DELETE BillInfo WHERE idFood IN (SELECT id FROM dbo.Food WHERE idCategory = {0})", idCategory);
            DataProvider.Instance.ExcuteQuery(query1);

            string query2 = string.Format("DELETE dbo.Bill WHERE id IN (SELECT idBill FROM dbo.BillInfo WHERE idFood IN (SELECT id FROM dbo.Food WHERE idCategory = {0}))", idCategory);
            DataProvider.Instance.ExcuteQuery(query2);

            string query = string.Format("DELETE Food WHERE idCategory = {0}", idCategory);
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
