using System.ComponentModel.DataAnnotations;
namespace webcuathuong.Models
	
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		[Required,MinLength(4,ErrorMessage ="Hãy nhập tên sản phẩm")]
		public string Ten { get; set; }
        public string MoTa { get; set; }
		[Required, MinLength(4, ErrorMessage = "Hãy nhập giá nhập sản phẩm")]
		public double GiaNhap {  get; set; }
		[Required, MinLength(4, ErrorMessage = "Hãy nhập lãi suất sản phẩm")]
		public double Lai { get; set; }
		[Required, MinLength(4, ErrorMessage = "Hãy nhập số lượng sản phẩm")]
		public int SoLuong {  get; set; }
		[Required, MinLength(4, ErrorMessage = "Hãy nhập loại sản phẩm")]
		public string Loai {  get; set; }
		 
		public Product() {}
		public Product(int id,string ten,string mota,double gianhap,double lai,int sl,string loai)
		{
			Id = id;
			Ten = ten;
			MoTa = mota;
			GiaNhap = gianhap;
			Lai = lai;
			SoLuong = sl;
			Loai = loai;
		}
	}
}
