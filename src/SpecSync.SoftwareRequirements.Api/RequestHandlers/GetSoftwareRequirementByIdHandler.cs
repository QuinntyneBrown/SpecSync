// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using MediatR;
using SpecSync.Models.SoftwareRequirement;

namespace SpecSync.SoftwareRequirements.Api.RequestHandlers;

public class GetSoftwareRequirementByIdHandler: IRequestHandler<GetSoftwareRequirementByIdRequest, GetSoftwareRequirementByIdResponse>
{
    private readonly ILogger<GetSoftwareRequirementByIdHandler> _logger;

    private readonly ISoftwareRequirementsRepository _softwareRequirementsRepository;

    public GetSoftwareRequirementByIdHandler(ILogger<GetSoftwareRequirementByIdHandler> logger,ISoftwareRequirementsRepository softwareRequirementsRepository){
        ArgumentNullException.ThrowIfNull(logger);
        ArgumentNullException.ThrowIfNull(softwareRequirementsRepository);

        _logger = logger;
        _softwareRequirementsRepository = softwareRequirementsRepository;

    }

    public async Task<GetSoftwareRequirementByIdResponse> Handle(GetSoftwareRequirementByIdRequest request,CancellationToken cancellationToken)
    {
        var softwareRequirement = _softwareRequirementsRepository.GetById(request.SoftwareRequirementId);

        return new GetSoftwareRequirementByIdResponse()
        {
            SoftwareRequirement = softwareRequirement
            .ToDto()
        };

    }

}

