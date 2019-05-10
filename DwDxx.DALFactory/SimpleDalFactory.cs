
using DwDxx.IDAL;

namespace DwDxx.DALFactory
{
	public partial class AbstractFactory
	{
			
		public static IBlogDal CreateBlogDal()
		{
			string fullClassName = NameSpace + ".BlogDal";
			return CreateInstance(fullClassName) as IBlogDal;
		}
		
		public static IPostDal CreatePostDal()
		{
			string fullClassName = NameSpace + ".PostDal";
			return CreateInstance(fullClassName) as IPostDal;
		}
	}
}