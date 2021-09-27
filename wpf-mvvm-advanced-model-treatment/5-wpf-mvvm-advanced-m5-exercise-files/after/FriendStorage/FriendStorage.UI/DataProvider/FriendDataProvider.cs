﻿using System;
using FriendStorage.DataAccess;
using FriendStorage.Model;

namespace FriendStorage.UI.DataProvider
{
  public class FriendDataProvider : IFriendDataProvider
  {
    private readonly Func<IDataService> _dataServiceCreator;

    public FriendDataProvider(Func<IDataService> dataServiceCreator)
    {
      _dataServiceCreator = dataServiceCreator;
    }

    public Friend GetFriendById(int id)
    {
      using (var dataService = _dataServiceCreator())
      {
        return dataService.GetFriendById(id);
      }
    }

    public void SaveFriend(Friend friend)
    {
      using (var dataService = _dataServiceCreator())
      {
        dataService.SaveFriend(friend);
      }
    }

    public void DeleteFriend(int id)
    {
      using (var dataService = _dataServiceCreator())
      {
        dataService.DeleteFriend(id);
      }
    }
  }
}
