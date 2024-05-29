using System.Reflection;
using System.Data.SqlClient;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography.X509Certificates;
using NeighbourComplaintRegistrationSystem.Models;
using System.Reflection.PortableExecutable;

namespace NeighbourComplaintRegistrationSystem.Services
{
    public class ComplaintService
    {
        private readonly SqlConnection _sqlConnection;

        public ComplaintService()
        {
            _sqlConnection = new SqlConnection(@"Data Source = SANPAD\MSSQLSERVER01; Initial Catalog = NCRS_Data; Integrated Security = True;");
            _sqlConnection.Open();
        }

        ~ComplaintService()
        {
            _sqlConnection.Close();
        }


        public async Task<string> InsertNewComplaintAsync(Models.Complaint complaint)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT_Complaint", _sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Name", complaint.Name);
                cmd.Parameters.AddWithValue("Address", complaint.Address);
                cmd.Parameters.AddWithValue("Category", (int)complaint.Category);
                cmd.Parameters.AddWithValue("ComplaintDescription", complaint.ComplaintDescription);
                cmd.Parameters.AddWithValue("SourceAddress", complaint.SourceAddress);

                return "Complaint added into NCRS.";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }


        public async Task<string> UpdateComplaintAsync(Models.Complaint complaint)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE_Complaint", _sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id", complaint.Id);
                cmd.Parameters.AddWithValue("Name", complaint.Name);
                cmd.Parameters.AddWithValue("Address", complaint.Address);
                cmd.Parameters.AddWithValue("Category", (int)complaint.Category);
                cmd.Parameters.AddWithValue("ComplaintDescription", complaint.ComplaintDescription);
                cmd.Parameters.AddWithValue("SourceAddress", complaint.SourceAddress);
                cmd.Parameters.AddWithValue("Status", (int)complaint.Status);

                int rowsAffected = await cmd.ExecuteNonQueryAsync();

                if (rowsAffected > 0)
                {
                    return "Complaint successfully updated.";
                }
                else
                    return "Update failed.";


            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public async Task<string> UpdateStatusAsync(Models.Complaint complaint)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE_Status", _sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id", complaint.Id);
                cmd.Parameters.AddWithValue("Status", (int)complaint.Status);

                int rowsAffected = await cmd.ExecuteNonQueryAsync();

                if (rowsAffected > 0)
                {
                    return "Status successfully updated.";
                }
                else
                    return "Status update failed.";


            }
            catch (Exception e)
            {
                return e.Message;
            }
        }



        public async Task<List<Models.Complaint>> GetComplaintsByNameAsync(Models.Complaint complaint)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("GET_ComplaintsByName", _sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Name", complaint.Name);

                SqlDataReader rd = await cmd.ExecuteReaderAsync();
                var complaints = new List<Models.Complaint>();
                while (await rd.ReadAsync()) 
                {
                    complaints.Add(new Models.Complaint()
                    {
                        Id = rd.GetValue(0).ToString(),
                        Name = rd.GetString(1),
                        Address = rd.GetString(2),
                        Category = (Models.Category)rd.GetValue(3),
                        ComplaintDescription = rd.GetString(4),
                        SourceAddress = rd.GetString(5),
                        Date = rd.GetDateTime(6),
                        Status = (Models.Status)rd.GetValue(7)

                    });
                }
                await rd.CloseAsync();
                return complaints;
            }
            catch (Exception e)
            {
                return null;
            }
        }



        public async Task<List<Models.Complaint>> GetAllComplaintsOrderedAsync(Models.Complaint complaint)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("GET_AllComplaintsOrdered", _sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader rd = await cmd.ExecuteReaderAsync();
                var complaints = new List<Models.Complaint>();

                if (!rd.HasRows)
                {
                    return complaints;
                }

                while (await rd.ReadAsync())
                {
                    complaints.Add(new Models.Complaint()
                    {
                        Id = rd.GetValue(0).ToString(),
                        Name = rd.GetString(1),
                        Address = rd.GetString(2),
                        Category = (Models.Category)rd.GetValue(3),
                        ComplaintDescription = rd.GetString(4),
                        SourceAddress = rd.GetString(5),
                        Date = rd.GetDateTime(6),
                        Status = (Models.Status)rd.GetValue(7)

                    });
                }
                await rd.CloseAsync();
                return complaints;
            }
            catch (Exception e)
            {
                return null;
            }
        }



        public async Task<string> GetComplaintsByDateAsync(Models.Complaint complaint)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("GET_ComplaintsByDate", _sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("StartDate", complaint.Date);
                cmd.Parameters.AddWithValue("EndDate", complaint.Date);

                SqlDataReader rd = await cmd.ExecuteReaderAsync();
                var complaints = new List<Models.Complaint>();
                while (await rd.ReadAsync())
                {
                    complaints.Add(new Models.Complaint()
                    {
                        Id = rd.GetValue(0).ToString(),
                        Name = rd.GetString(1),
                        Address = rd.GetString(2),
                        Category = (Models.Category)rd.GetValue(3),
                        ComplaintDescription = rd.GetString(4),
                        SourceAddress = rd.GetString(5),
                        Date = rd.GetDateTime(6),
                        Status = (Models.Status)rd.GetValue(7)

                    });
                }
                await rd.CloseAsync();
                return "success";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
