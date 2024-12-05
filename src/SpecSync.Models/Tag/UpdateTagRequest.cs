// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using MediatR;

namespace Tag.Models.Tag;

public class UpdateTagRequest: IRequest<UpdateTagResponse>
{
    public Guid TagId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

