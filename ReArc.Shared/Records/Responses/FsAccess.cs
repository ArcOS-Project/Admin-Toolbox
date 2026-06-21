using System;
using System.Collections.Generic;
using System.Text;

namespace ReArc.Shared.Records.Responses;

public record class FsAccess(
    string _id,
    string UserId,
    string Path,
    string Accessor,
    string CreatedAt);