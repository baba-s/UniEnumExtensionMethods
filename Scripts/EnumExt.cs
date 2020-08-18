using System;
using UnityEngine;

namespace Kogane
{
	/// <summary>
	/// Enum 型の拡張メソッドを管理するクラス
	/// </summary>
	public static class EnumExt
	{
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// 前の値に進みます。最小値を超える場合は最大値に戻ります
		/// </summary>
		public static T PrevLoop<T>( this T self )
		{
			var intValue  = Convert.ToInt32( self );
			var length    = Enum.GetValues( typeof( T ) ).Length;
			var nextValue = ( intValue - 1 + length ) % length;
			var enumValue = Enum.ToObject( typeof( T ), nextValue );

			return ( T ) enumValue;
		}

		/// <summary>
		/// 次の値に進みます。最大値を超える場合は初期値に戻ります
		/// </summary>
		public static T NextLoop<T>( this T self )
		{
			var intValue  = Convert.ToInt32( self );
			var nextValue = ( intValue + 1 ) % Enum.GetValues( typeof( T ) ).Length;
			var enumValue = Enum.ToObject( typeof( T ), nextValue );

			return ( T ) enumValue;
		}

		/// <summary>
		/// 前の値に進みます。最小値を超える場合は止まります
		/// </summary>
		public static T Prev<T>( this T self )
		{
			var intValue  = Convert.ToInt32( self );
			var nextValue = Mathf.Max( 0, intValue - 1 );
			var enumValue = Enum.ToObject( typeof( T ), nextValue );

			return ( T ) enumValue;
		}

		/// <summary>
		/// 次の値に進みます。最大値を超える場合は止まります
		/// </summary>
		public static T Next<T>( this T self )
		{
			var intValue  = Convert.ToInt32( self );
			var nextValue = Mathf.Min( Enum.GetValues( typeof( T ) ).Length, intValue + 1 );
			var enumValue = Enum.ToObject( typeof( T ), nextValue );

			return ( T ) enumValue;
		}
	}
}