// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using MediatR;

namespace SpecSync.Models.SoftwareRequirement;

public class GetSoftwareRequirementByIdRequest: IRequest<GetSoftwareRequirementByIdResponse>
{
    public string SoftwareRequirementId { get; set; }
}

