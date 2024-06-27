using QLQuanAn.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLQuanAn.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "SELECT * FROM FoodCategory";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);

                list.Add(category);
            }

            return list;
        }

        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "SELECT * FROM FoodCategory where id = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);

                return category;
            }

            return category;
        }

        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT dbo.FoodCategory (name) VALUES (N'{0}')", name);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(int idCategory, string nameCategory)
        {
            string query = string.Format("UPDATE dbo.FoodCategory SET name = N'{0}' WHERE id = {1}", nameCategory, idCategory);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCategory(int idCategory)
        {
            int result = 0;
            ////xóa BillInfo => xóa Food => Category 
            //List<string> IDFood = new List<string>();

            //IDFood.Add(string.Format("SELECT f.id FROM dbo.Food AS f, dbo.FoodCategory fc WHERE f.idCategory = fc.id AND idCategory = {0}", idCategory));

            //if (IDFood.Count > 0)
            //{
            //    string[] temp = new string[IDFood.Count];


            //    for (int i = 0; i <= temp.Length; i++)
            //    {
            //        if (FoodDAO.Instance.DeleteFood(Convert.ToInt32(temp[i])))
            //        {
            //            string query = string.Format("DELETE dbo.FoodCategory WHERE id = {0}", idCategory);
            //            result = DataProvider.Instance.ExcuteNonQuery(query);
            //        }
            //    }
            //}


            return result > 0;
        }

    }
}