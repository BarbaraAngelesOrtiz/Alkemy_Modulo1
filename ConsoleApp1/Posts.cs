using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1 
{
	public class Posts ()
	{
 
    public int IDPost { get; set; }
    public string Title { get; set; }
    public DateTime date { get; set; }
    public string content { get; set; }
    public string Post { get; set; }
    public Usuario user  { get; set; }

	}
}
