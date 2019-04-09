
using DwDxx.IDAL;
using DwDxx.Model;

namespace DwDxx.DAL
{
		
	public partial class BlogDal :BaseDal<Blog>,IBlogDal
    {

    }
		
	public partial class PostDal :BaseDal<Post>,IPostDal
    {

    }
	
}