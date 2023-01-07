namespace WPF_Template_MVVM.Models
{
	public class User
    {
		#region Fields
		private string _name = "";
		private string _firstName = "";
		#endregion

		#region Properties
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}
		#endregion

		#region Constructor
		public User(string name, string firstName)
		{
			Name = name;
			FirstName = firstName;
		} 
		#endregion
	}
}
