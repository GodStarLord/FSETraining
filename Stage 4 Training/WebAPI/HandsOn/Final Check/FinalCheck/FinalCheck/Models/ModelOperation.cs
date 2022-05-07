using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FinalCheck.Models
{
    public class ModelOperation
    {
        private readonly string connStr = @"";
        private readonly FinalCheckContext _context;

        public ModelOperation(FinalCheckContext context)
        {
            _context = context;
        }

        //Movie Operations
        public List<Movie> GetMovies()
        {
            //List<Movie> Movies = new List<Movie>();

            //string cmdText = "SELECT * FROM Movies";
            //SqlDataAdapter da = new SqlDataAdapter(cmdText, connStr);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //foreach (DataRow item in dt.Rows)
            //{
            //    Movie obj = new Movie();
            //    obj.Id = (int)item["Id"];
            //    obj.Title = (string)item["Title"];
            //    obj.Active = (bool)item["Active"];
            //    obj.BoxOffice = (string)item["BoxOffice"];
            //    obj.DateOfLaunch = Convert.ToDateTime(item["DateOfLaunch"]);
            //    obj.HasTeaser = (bool)(item["HasTeaser"]);
            //    obj.GenreId = (int)(item["GenreId"]);

            //    Movies.Add(obj);
            //}

            //return Movies;

            var moviesList = _context.Movies.ToList();

            return moviesList;
        }

        public void AddMovie(Movie movie)
        {
            //string cmdText = string.Format("INSERT INTO Movies VALUES('{0}', '{1}', '{2}' , '{3}' ,'{4}', {5} )", obj.Title, obj.BoxOffice, obj.Active, obj.DateOfLaunch.ToShortDateString(), obj.HasTeaser, obj.GenreId );

            //SqlConnection conn = new SqlConnection(connStr);

            //SqlCommand cmd = new SqlCommand(cmdText, conn);

            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            _context.Add(movie);
            _context.SaveChanges();
        }

        public Movie GetMovie(int n)
        {
            //Movie obj = null;

            //string cmdText = "SELECT * FROM Movies WHERE Id=" + n;
            //string connStr = @"Data Source=PC445664\SQLEXPRESS;Initial Catalog=testdb;Persist Security Info=True;User ID=sa;Password=Rihabkasim8";
            //SqlConnection conn = new SqlConnection(connStr);
            //SqlCommand cmd = new SqlCommand(cmdText, conn);
            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.HasRows == true)
            //{
            //    dr.Read();
            //    obj = new Movie();
            //    obj.Id = (int)dr["Id"];
            //    obj.Title = (string)dr["Title"];
            //    obj.Active = (bool)dr["Active"];
            //    obj.BoxOffice = (string)dr["BoxOffice"];
            //    obj.DateOfLaunch = Convert.ToDateTime(dr["DateOfLaunch"]);
            //    obj.HasTeaser = (bool)(dr["HasTeaser"]);
            //    obj.GenreId = (int)(dr["GenreId"]);
            //}

            //dr.Close();
            //conn.Close();
            //return obj;

            var movie = _context.Movies.Where(x => x.Id == n).FirstOrDefault();

            return movie;
        }

        public void UpdateMovie(Movie movie)
        {
            //string cmdText = string.Format("UPDATE Movie SET Active='{0}' where Id={1}", movie.Active, movie.Id);

            //SqlConnection conn = new SqlConnection(connStr);
            //SqlCommand cmd = new SqlCommand(cmdText, conn);
            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Close();
            //conn.Close();

            var result = _context.Movies.Where(x => x.Id == movie.Id).FirstOrDefault();
            result.Active = movie.Active;
            result.BoxOffice = movie.BoxOffice;
            result.DateOfLaunch = movie.DateOfLaunch;
            result.GenreId = movie.GenreId;
            result.HasTeaser = movie.HasTeaser;
            result.Title = movie.Title;

            _context.SaveChanges();
        }

        public void DeleteMovie( /*Movie movie*/ int id)
        {

            //string cmdText = string.Format("DELETE FROM Movie WHERE Id={0}", movie.Id);

            //SqlConnection conn = new SqlConnection(connStr);
            //SqlCommand cmd = new SqlCommand(cmdText, conn);

            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Close();
            //conn.Close();

            var result = _context.Movies.Where(x => x.Id == id).SingleOrDefault();
            _context.Movies.Remove(result);
            _context.SaveChanges();
        }

        //Favorite Operations
        public List<Favorite> GetFavoriteMovies(int MovieUserId)
        {
            //List<Favorite> FavoriteMovie = new List<Favorite>();
            //string cmdText = "SELECT * FROM Favorite WHERE MovieUserId=" + MovieUserId;
            //SqlDataAdapter da = new SqlDataAdapter(cmdText, connStr);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //foreach (DataRow item in dt.Rows)
            //{
            //    Favorite obj = new Favorite();
            //    obj.Id = (int) item["Id"];
            //    obj.UserId = (int) item["UserId"];
            //    obj.MovieId = (int) item["MovieId"];


            //    FavoriteMovie.Add(obj);
            //}

            //return FavoriteMovie;

            var favoriteList = _context.Favorites.Include(x => x.Movie).Where(x => x.UserId == MovieUserId).ToList();
            return favoriteList;
        }

        public Favorite GetFavoriteItem(int n)
        {
            //Favorite obj = null;

            //string cmdText = "SELECT * FROM Favorites WHERE Id=" + n;
            //SqlConnection conn = new SqlConnection(connStr);
            //SqlCommand cmd = new SqlCommand(cmdText, conn);
            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.HasRows == true)
            //{
            //    dr.Read();
            //    obj = new Favorite();
            //    obj.Id = (int)dr["Id"];
            //    obj.UserId = (int)dr["UserId"];
            //    obj.MovieId = (int)dr["MovieId"];

            //}

            //dr.Close();
            //conn.Close();
            //return obj;
            Favorite favorite = (Favorite)_context.Favorites.Include(x => x.Movie).Where(x => x.Id == n);
            return favorite;
        }

        public void AddFavoriteMovie(Favorite favorite)
        {
            //string cmdText = string.Format("INSERT INTO Favorite VALUES({0}, {1})", obj.UserId, obj.MovieId);

            //SqlConnection conn = new SqlConnection(connStr);

            //SqlCommand cmd = new SqlCommand(cmdText, conn);

            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            _context.Favorites.Add(favorite);
            _context.SaveChanges();
        }

        public void DeleteFavoriteMovie(int id)
        {
            //string cmdText = string.Format("DELETE FROM Favorite WHERE MovieId={0}", id);

            //SqlConnection conn = new SqlConnection(connStr);
            //SqlCommand cmd = new SqlCommand(cmdText, conn);

            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Close();
            //conn.Close();
            var favorite = (Favorite) _context.Favorites.Include(x => x.Movie).Where(x => x.MovieId == id);
            _context.Favorites.Remove(favorite);
            _context.SaveChanges();
        }

        //User Operations
        public void AddMovieUser(User obj)
        {
            //string cmdText = string.Format("INSERT INTO Login VALUES('{0}','{1}','{2}','{3}')", obj.FirstName, obj.LastName, obj.Password, obj.ConfirmPassword);

            //SqlConnection conn = new SqlConnection(connStr);

            //SqlCommand cmd = new SqlCommand(cmdText, conn);

            //conn.Open();
            //cmd.ExecuteNonQuery();
            //conn.Close();

            _context.Users.Add(obj);
            _context.SaveChanges();
        }

        public User GetMovieUser(int id)
        {
            //User obj = null;

            //string cmdText = "SELECT * FROM Login WHERE Id=" + id;
            //SqlConnection conn = new SqlConnection(connStr);
            //SqlCommand cmd = new SqlCommand(cmdText, conn);
            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.HasRows == true)
            //{
            //    dr.Read();
            //    obj = new User();
            //    obj.Id = (int)dr["Id"];
            //    obj.FirstName = (string)dr["FirstName"];
            //    obj.LastName = (string)dr["LastName"];
            //    obj.Password = (string)dr["Password"];
            //    obj.ConfirmPassword = (string)dr["ConfirmPassword"];

            //}

            //dr.Close();
            //conn.Close();
            //return obj;
            User user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            return user;
        }
    }
}
