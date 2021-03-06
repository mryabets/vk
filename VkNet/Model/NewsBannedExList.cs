﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VkNet.Model.Attachments;
using VkNet.Utils;

namespace VkNet.Model
{
	/// <summary>
	/// 
	/// </summary>
	public class NewsBannedExList
	{
		/// <summary>
		/// В поле groups содержится массив идентификаторов сообществ, которые пользователь скрыл из ленты новостей.
		/// </summary>
		public ReadOnlyCollection<Group> Groups
		{ get; set; }

		/// <summary>
		/// В поле members содержится массив идентификаторов друзей, которые пользователь скрыл из ленты новостей.
		/// </summary>
		public ReadOnlyCollection<User> profiles
		{ get; set; }

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response">Ответ сервера.</param>
		/// <returns></returns>
		internal static NewsBannedExList FromJson(VkResponse response)
		{
			VkResponseArray names = response["groups"];
			VkResponseArray profiles = response["profiles"];
			var bannedList = new NewsBannedExList
			{
				Groups = names.ToReadOnlyCollectionOf<Group>(x => x),
				profiles = profiles.ToReadOnlyCollectionOf<User>(x => x)
			};

			return bannedList;
		}
	}
}
