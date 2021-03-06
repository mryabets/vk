﻿using System;
using System.Collections.Generic;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;

namespace VkNet.Model.RequestParams.NewsFeed
{
	/// <summary>
	/// Список параметров запроса newsfeed.get
	/// </summary>
	public class GetCommentsParams
	{
		/// <summary>
		/// Перечисленные через запятую названия списков новостей, которые необходимо получить. В данный момент поддерживаются следующие списки новостей: post — новые записи со стен photo — новые фотографии photo_tag — новые отметки на фотографиях wall_photo — новые фотографии на стенах friend — новые друзья note — новые заметки Если параметр не задан, то будут получены все возможные списки новостей.  список строк, разделенных через запятую.
		/// </summary>
		public NewsTypes Filters
		{ get; set; }

		/// <summary>
		/// Идентификатор объекта, комментарии к репостам которого необходимо вернуть, например wall1_45486. 
		/// </summary>
		/// <remarks>
		/// Если указан данный параметр, параметр filters указывать необязательно.
		/// </remarks>
		public string Reposts
		{ get; set; }

		/// <summary>
		/// Время в формате unixtime, начиная с которого следует получить новости для текущего пользователя.
		/// </summary>
		public string StartTime
		{ get; set; }

		/// <summary>
		/// Время в формате unixtime, до которого следует получить новости для текущего пользователя. Если параметр не задан, то он считается равным текущему времени. положительное число.
		/// </summary>
		public string EndTime
		{ get; set; }

		/// <summary>
		/// Количество комментариев к записям, которые нужно получить.
		/// </summary>
		public ulong LastCommentsCount
		{ get; set; }

		/// <summary>
		/// Идентификатор, необходимый для получения следующей страницы результатов. Значение, необходимое для передачи в этом параметре, возвращается в поле ответа next_from. строка, доступен начиная с версии 5.13.
		/// </summary>
		public long StartFrom
		{ get; set; }

		/// <summary>
		/// Указывает, какое максимальное число новостей следует возвращать, но не более 100. По умолчанию 50.
		/// </summary>
		public ushort Count
		{ get; set; }

		/// <summary>
		/// Список дополнительных полей профилей, которые необходимо вернуть. список строк, разделенных через запятую.
		/// </summary>
		public UsersFields Fields
		{ get; set; }

	}
}
