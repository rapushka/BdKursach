namespace Code.Data.Config
{
	public interface IStorage
	{
		void Save<T>(T data);

		T Load<T>(T defaultValue);

		void Delete<T>();
	}
}