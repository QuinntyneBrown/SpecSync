// Copyright (c) Quinntyne Brown. All Rights Reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using FluentValidation;

namespace SpecSync.Models.SoftwareRequirement;

public class CreateSoftwareRequirementRequestValidator: AbstractValidator<CreateSoftwareRequirementRequest>
{
    public CreateSoftwareRequirementRequestValidator()
    {
        RuleFor(x => x.Description).NotNull().NotEmpty();
    }
}

