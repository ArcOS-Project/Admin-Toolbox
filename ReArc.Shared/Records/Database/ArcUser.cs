using ReArc.Shared.Records.Database.User;

namespace ReArc.Shared.Records.Database;

public record class ArcUser(
    string Username,
    UserPreferences Preferences,
    bool Admin,
    string[] AdminScopes,
    bool Approved,
    bool IsSystem,
#pragma warning disable IDE1006
    string _id,
#pragma warning restore IDE1006
    string Email,
    long StorageSize,
    int AccountNumber,
    string CreatedAt,
    string UpdatedAt
);