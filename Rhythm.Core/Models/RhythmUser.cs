﻿#nullable enable

namespace Rhythm.Core.Models;

public class RhythmUser
{
    public required string UserId
    {
        get; set;
    }

    public required string UserName
    {
        get; set;
    }

    public required string Password
    {
        get; set;
    }

    public string? Country
    {
        get; set;
    }

    public string? Gender
    {
        get; set;
    }

    public required byte[] UserImage
    {
        get; set;
    }

    public int PlaylistCount
    {
        get; set;
    }

    public int FavoriteSongCount
    {
        get; set;
    }

    public DateTime CreatedAt
    {
        get; set;
    }

    public DateTime UpdatedAt
    {
        get; set;
    }

    public override string ToString()
    {
        var userString = $"User ID: {UserId}\n" +
            $"Username: {UserName}\n" +
            $"Country: {Country}\n" +
            $"Gender: {Gender}\n" +
            $"Playlist Count: {PlaylistCount}\n" +
            $"Favorite Song Count: {FavoriteSongCount}\n" +
            $"Created At: {CreatedAt}\n" +
            $"Updated At: {UpdatedAt}\n";
        return userString;
    }
}
