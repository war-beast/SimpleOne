namespace SimpleAlgo.Models;

public class Result
{
	public string Error { get; } = string.Empty;
	public bool IsSuccess { get; }
	public bool IsFailure => !IsSuccess;

	public Result()
	{
		IsSuccess = true;
	}

	public Result(string error)
	{
		IsSuccess = false;
		Error = error;
	}

	public static Result Success()
	{
		return new Result();
	}
	public static Result Failure(string error)
	{
		return new Result(error);
	}
	public static Result<TData> Success<TData>(TData data)
	{
		return new Result<TData>(data);
	}

	public static Result<TData> Failure<TData>(string error)
	{
		return new Result<TData>(error);
	}

}

public class Result<T> : Result
{
	public Result(T data) : base()
	{
		Data = data;
	}

	public Result(string error) : base(error)
	{
	}

	public T Data { get; }
}