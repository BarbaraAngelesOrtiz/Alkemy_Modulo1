using System;
using System.ComponentModel.DataAnnotations;


namespace ConsoleApp1
{
	public class Comments ()
	{
      
    public int IDComment { get; set; }
    public DateTime date { get; set; }
    public string content { get; set; }
    public Usuario user { get; set; }

}
	
}
