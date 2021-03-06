﻿using System.Security.Policy;
using VkNet.Enums.SafetyEnums;

namespace VkNet.Model.RequestParams.Likes
{
	/// <summary>
	/// Параметры запроса likes.getList
	/// </summary>
	public class GetListParams
	{
		/// <summary>
		/// Параметры запроса likes.getList
		/// </summary>
		public GetListParams()
		{
			Type = LikeObjectType.Post;
			Filter = LikesFilter.Likes;
		}

		/// <summary>
		/// Тип объекта. строка, обязательный параметр.
		/// </summary>
		public LikeObjectType Type
		{ get; set; }

		/// <summary>
		/// Идентификатор владельца Like-объекта: id пользователя, id сообщества (со знаком «минус») или id приложения. Если параметр type равен sitepage, то в качестве owner_id необходимо передавать id приложения. Если параметр не задан, то считается, что он равен либо идентификатору текущего пользователя, либо идентификатору текущего приложения (если type равен sitepage). целое число.
		/// </summary>
		public long? OwnerId
		{ get; set; }

		/// <summary>
		/// Идентификатор Like-объекта. Если type равен sitepage, то параметр item_id может содержать значение параметра page_id, используемый при инициализации виджета «Мне нравится». целое число.
		/// </summary>
		public long ItemId
		{ get; set; }

		/// <summary>
		/// Url страницы, на которой установлен виджет «Мне нравится». Используется вместо параметра item_id, если при размещении виджета не был указан page_id. строка.
		/// </summary>
		public Url PageUrl
		{ get; set; }

		/// <summary>
		/// Указывает, следует ли вернуть всех пользователей, добавивших объект в список "Мне нравится" или только тех, которые рассказали о нем друзьям. Параметр может принимать следующие значения:строка.
		/// </summary>
		public LikesFilter Filter
		{ get; set; }

		/// <summary>
		/// Указывает, необходимо ли возвращать только пользователей, которые являются друзьями текущего пользователя.
		/// </summary>
		public bool? FriendsOnly
		{ get; set; }

		/// <summary>
		/// Смещение, относительно начала списка, для выборки определенного подмножества. Если параметр не задан, то считается, что он равен 0.
		/// </summary>
		public uint? Offset
		{ get; set; }

		/// <summary>
		/// Количество возвращаемых идентификаторов пользователей.
		/// </summary>
		public uint? Count
		{ get; set; }

		/// <summary>
		/// Не возвращать самого пользователя.
		/// </summary>
		public bool? SkipOwn
		{ get; set; }

	}
}
