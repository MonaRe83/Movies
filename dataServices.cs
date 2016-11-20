using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace Movies_Students_Pro
{
    public class dataServices
    {
        protected MySqlConnection openTheConnection()
        {
            //open a connection to the database and return it
            string theConnString = "server=localhost;"
            + "User Id=admin001;password=admin;"
            + "database=movies";
            MySqlConnection conn = new MySqlConnection(theConnString);
            conn.Open();
            return conn;
        }

        public void accessDB(String aQuery, SortedList aList)
        {
          
            // open a connection to the database
            MySqlConnection conn = openTheConnection();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = aQuery;

                // convert our key to a string to check it 
                String firstKey = (String)aList.GetKey(0);
                if (firstKey == "DataGridView")
                {
                 //convert the value to a data drivnView
                DataGridView aGrid = (DataGridView) aList.GetByIndex(0);

                //call a method to get the datafrom the database
                getFromDB(cmd, aGrid);
            }
            else
            {
                alterDB(cmd, aList);
            }
               
         }
            catch (Exception e)
            {
            MessageBox.Show(e.Message);
            }


        }


        private void alterDB(MySqlCommand cmd, SortedList aList)
        {
            cmd.ExecuteScalar();
 
        }

        private void getFromDB(MySqlCommand cmd, DataGridView aGrid)
        {
          
        }

   

    }

    public class moviesdataServices : dataServices
    {

        public void loadMovies(DataGridView aGridControl)
        {  // call a generic method to load a grid control
            loadGridView(aGridControl, "Select*from Movies");
        }
        public void updateMovie(SortedList dataList)
        {
            accessDB("UPDATE Movies SET MovieRating=@mMovieRating,MovieAct=@mMovieActors,this.dateTimePicker1=@mMovieProductionDate,MovieD=@mMovieD", dataList);
        }

        public void deleteMovie(SortedList dataList)
        {
            accessDB("DELETE* From Movies Where ID=@mID", dataList);
        }
        public void insertMovie(SortedList dataList)
        {
            accessDB("INSERT INTO Movies (MovieRating,MovieName,"
           + " MoviesActors,ProdDate,MovieD)"
           + " VALUES(@mMovieRating,@mMovieName,@mMovieActors,@mMovieProductionDate,@mMovieD)", dataList);
        }

       

        private void loadGridView(DataGridView aGridControl, String aQuery)
        {
            MySqlConnection conn = openTheConnection();
            try
            {
                MySqlCommand cmd = conn.CreateCommand(); // Setup the new adaper and dataset
                cmd.CommandText = aQuery;

                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapt.Fill(ds);
                aGridControl.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }

        }

    }
} 
    

