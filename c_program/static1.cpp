class shape
{
	public:
		virtual void draw()
		{
			cout<<"draw method of shape"<<endl;
		}
};
class rectangle:public shape
{
	public:
		void draw()
		{
			cout<<"draw method of rectangle class"<<endl;
		}
}
