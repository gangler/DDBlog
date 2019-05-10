
using DwDxx.Model;
using DwDxx.IBLL;

namespace DwDxx.BLL
{
		
	public partial class BlogService :BaseService<Blog>,IBlogService
    {
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.BlogDal;
        }
    }  
		
	public partial class PostService :BaseService<Post>,IPostService
    {
		 public override void SetCurrentDal()
        {
            CurrentDal = this.CurrentDBSession.PostDal;
        }
    }  
}