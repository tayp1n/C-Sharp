using System;

namespace Common
{
	public interface ICloneable<T> : ICloneable
    {
        new T Clone();
    }

    public interface ICopy<T>
    {
        void CopyTo(T other);
        void CopyFrom(T other);
    }
}
