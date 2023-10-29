using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace u19268468_HW03.Models
{
    public static class BorrowCountModel
    {
        //Method to count borrow amount for data range in graph 
        //SQL query counts borrows for each book for specific date range

        public static List<AxisModel> GetBorrowCountForBooks(DateTime startDate, DateTime endDate)
        {
            string connectionString = "data source = LAPTOP-8OO64UPG; initial catalog = Library; integrated security = True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<AxisModel> result = new List<AxisModel>();

                connection.Open();

                
                string sqlQuery = @"
                    SELECT b.bookid, b.name AS book_name, COUNT(borrows.borrowId) AS borrow_count
                    FROM books b
                    LEFT JOIN borrows ON b.bookid = borrows.bookid
                    WHERE borrows.broughtDate >= borrows.takenDate
                    GROUP BY b.bookid, b.name
                    ORDER BY borrow_count DESC;
                ";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.Add(new SqlParameter("@StartDate", startDate));
                    command.Parameters.Add(new SqlParameter("@EndDate", endDate));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bookId = (int)reader["bookid"];
                            string bookName = (string)reader["book_name"];
                            int borrowCount = (int)reader["borrow_count"];
                            result.Add(new AxisModel(borrowCount, bookName));
                        }
                    }
                }

                return result;
            }
        }
    }
}