using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace map_router.src
{
    public partial class Router : System.Web.UI.Page
    {
        // Map to store points

        public static List <Tuple <decimal, decimal>> list_of_points = new List <Tuple <decimal, decimal>>();
        public static SortedDictionary<string, string> algorithms_dictonary = new SortedDictionary<string, string>();

        private void init_algorithms_dictonary()
        {
            algorithms_dictonary.Add("Alg1", "ALG_DIJ");
            algorithms_dictonary.Add("Alg2", "ALG_PRIM");
            algorithms_dictonary.Add("Alg3", "ALG_KRUSK");
            algorithms_dictonary.Add("Alg4", "ALG_ASTAR");
            algorithms_dictonary.Add("Alg5", "ALG_DFS");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            init_algorithms_dictonary();
        }

        private Tuple<decimal, decimal> get_xy_as_tuple()
        {
            decimal x_from_webpage = decimal.Parse(x_coordinate.Text.ToString());
            decimal y_from_webpage = decimal.Parse(y_coordinate.Text.ToString());
            var point = new Tuple <decimal, decimal>(x_from_webpage, y_from_webpage);
            return point;
        }

        private string get_algorithm()
        {
            string algorithm_from_webpage = algorithm_dropdown_list.SelectedValue;
            string algorithm = algorithms_dictonary[algorithm_from_webpage];
            return algorithm;
        }

        private List <Tuple <decimal, decimal>> get_route_from_algorithm(string algorithm)
        {
            List <Tuple <decimal, decimal>> path_in_order = new List <Tuple <decimal, decimal>>();
            switch (algorithm)
            {
                case "ALG_DIJ":
                    break;
                case "ALG_PRIM":
                    break;
                case "ALG_KRUSK":
                    break;
                case "ALG_ASTAR":
                    break;
                case "ALG_DFS":
                    break;
                case "ALG_BFS":
                    break;
                default:
                    break;
            }
            return path_in_order;
        }

        protected void add_coordinates(object sender, EventArgs e)
        {
            Tuple <decimal, decimal> point = get_xy_as_tuple();
            list_of_points.Add(point);
        }

        protected void generate_route(object sender, EventArgs e)
        {
            string algorithm = get_algorithm();
            List <Tuple <decimal, decimal>> path_in_order = get_route_from_algorithm(algorithm);
            Console.WriteLine(path_in_order);
        }
    }
}