
using DwDxx.IDAL;

namespace DwDxx.DALFactory
{
public partial class DBSession : IDBSession
    {
	private IBlogDal _BlogDal;
    public IBlogDal BlogDal
    {
        get
        {
            if(_BlogDal == null)
            {
                _BlogDal = AbstractFactory.CreateBlogDal();
            }
            return _BlogDal;
        }
        set { _BlogDal = value; }
    }
	private IPostDal _PostDal;
    public IPostDal PostDal
    {
        get
        {
            if(_PostDal == null)
            {
                _PostDal = AbstractFactory.CreatePostDal();
            }
            return _PostDal;
        }
        set { _PostDal = value; }
    }
	}
}