﻿namespace DemoApp.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);

    string[] GetPageKeys();
}
