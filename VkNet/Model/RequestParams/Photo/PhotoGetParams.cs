﻿using System;
using System.Collections.Generic;
using VkNet.Enums.SafetyEnums;

namespace VkNet.Model.RequestParams.Photo
{
	/// <summary>
	/// Список параметров для метода photos.get
	/// </summary>
	public class PhotoGetParams
	{
		/// <summary>
		/// Идентификатор владельца альбома. целое число, по умолчанию идентификатор текущего пользователя.
		/// </summary>
		public long OwnerId
		{ get; set; }

		/// <summary>
		/// Идентификатор альбома. Для служебных альбомов используются следующие идентификаторы: строка.
		/// </summary>
		public PhotoAlbumType AlbumId
		{ get; set; }

		/// <summary>
		/// Идентификаторы фотографий, информацию о которых необходимо вернуть.
		/// </summary>
		public IEnumerable<string> PhotoIds
		{ get; set; }

		/// <summary>
		/// Порядок сортировки фотографий (<c>true</c> — антихронологический, <c>false</c> — хронологический).
		/// </summary>
		public bool? Rev
		{ get; set; }

		/// <summary>
		/// <c>true</c> — будут возвращены дополнительные поля likes, comments, tags, can_comment. Поля comments и tags содержат только количество объектов. По умолчанию данные поля не возвращается.
		/// </summary>
		public bool? Extended
		{ get; set; }

		/// <summary>
		/// Тип новости получаемый в поле type метода newsfeed.get, для получения только загруженных пользователем фотографий, либо только фотографий, на которых он был отмечен. Может принимать значения photo, photo_tag.
		/// </summary>
		public Type FeedType
		{ get; set; }

		/// <summary>
		/// unixtime, который может быть получен методом newsfeed.get в поле date, для получения всех фотографий загруженных пользователем в определённый день либо на которых пользователь был отмечен. Также нужно указать параметр uid пользователя, с которым произошло событие.
		/// </summary>
		public string Feed
		{ get; set; }

		/// <summary>
		/// Параметр, указывающий нужно ли возвращать ли доступные размеры фотографии в специальном формате.
		/// </summary>
		public bool? PhotoSizes
		{ get; set; }

		/// <summary>
		/// Отступ, необходимый для получения определенного подмножества записей.
		/// </summary>
		public ulong? Offset
		{ get; set; }

		/// <summary>
		/// Количество записей, которое будет получено. положительное число, максимальное значение 1000.
		/// </summary>
		public ulong? Count
		{ get; set; }

	}
}
