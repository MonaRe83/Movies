using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_Students_Pro
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadMoviesGrid();
        }

        public void loadMoviesGrid()
        {
            // create a data services object , load up the movies from db and destroy the object
             moviesdataServices ds= new moviesdataServices();
             ds.loadMovies(dataGridView1);
             ds = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            this.Movie.Text = dataGridView1.Rows[rowIndex].Cells["ID"].Value.ToString();
            this.MovieName.Text = dataGridView1.Rows[rowIndex].Cells["MovieName"].Value.ToString();
            this.MovieRating.Text = dataGridView1.Rows[rowIndex].Cells["MovieRating"].Value.ToString();
            this.MovieAct.Text = dataGridView1.Rows[rowIndex].Cells["MovieActors"].Value.ToString();
            this.MovieD.Text = dataGridView1.Rows[rowIndex].Cells["MovieDescription"].Value.ToString();
            this.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[rowIndex].Cells["MovieProductionDate"].Value);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Movie_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //create a new list containing the data
            SortedList dataList = new SortedList();
            dataList.Add("@mID", this.Movie.Text);
            dataList.Add("@mMovieName", this.MovieName.Text);
            dataList.Add("@mMovieRating", this.MovieRating.Text);
            dataList.Add("@mMovieActors", this.MovieAct.Text);
            dataList.Add("@mMovieD", this.MovieD.Text);
            dataList.Add("@mMovieProductionDate", this.dateTimePicker1.Value);

            moviesdataServices ds = new moviesdataServices();
            ds.updateMovie(dataList);
            ds = null;

            loadMoviesGrid();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortedList dataList = new SortedList();
            dataList.Add("@mID", this.Movie.Text);

            moviesdataServices ds = new moviesdataServices();
            ds.deleteMovie(dataList);
            ds = null;

            loadMoviesGrid();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //create a new list containing the data
            SortedList dataList = new SortedList();
            dataList.Add("@mID", this.Movie.Text);
            dataList.Add("@mMovieName", this.MovieName.Text);
            dataList.Add("@mMovieRating", this.MovieRating.Text);
            dataList.Add("@mMovieActors", this.MovieAct.Text);
            dataList.Add("@mMovieD", this.MovieD.Text);
            dataList.Add("@mMovieProductionDate", this.dateTimePicker1.Value);

            moviesdataServices ds = new moviesdataServices();
            ds.insertMovie(dataList);
            ds = null;

            loadMoviesGrid();
        }

    }
}
