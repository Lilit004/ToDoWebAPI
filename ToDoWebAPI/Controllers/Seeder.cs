using FluentValidation.Validators;
using Microsoft.EntityFrameworkCore;

private async Task SeedTaskStatusesObject()
{
    var taskStatusesMigrated = await _context.ObjectTypes.AnyAsync(x => x.Name == "TaskStatuses");
    if (!taskStatusesMigrated)
    {
        var taskStatusObject = new ObjectType
        {
            CanCustomize = false,
            CanSoftDelete = false,
            Description = "Task Statuses object type",
            HasCustomFields = true,
            Display = "Task Statuses",
            Name = "TaskStatuses",
            IsSystemModel = true,
            Properties = new List<ObjectProperty>
                        {
                            new ObjectProperty
                            {
                                Name = "Id",
                                Display = "Id",
                                DbTypeId = 2,
                                IsCustom = false,
                                IsPrimary = true,
                                Description = "Task Statuses autoincrement identifier",
                                DefaultValue = String.Empty,
                                DisplayType = "Number"
                            },
                            new ObjectProperty
                            {
                                Name = "Name",
                                Display = "Name",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Task Status Name",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                                PropertyValidators = new List<PropertyValidator>
                                {
                                    new PropertyValidator
                                    {
                                        ValidatorId = 1,
                                        ErrorMessage = "Name is required",
                                        ConstraintsJsonString = String.Empty
                                    }
                                }
                            }
                        },
            CanAudit = true,
            PropertiesCount = 2
        };
        await _context.ObjectTypes.AddAsync(taskStatusObject);
        await _context.SaveChangesAsync();
    }
}

private async Task SeedValidatorsObject()
{
    var validatorsMigrated = await _context.ObjectTypes.AnyAsync(x => x.Name == "Validators");
    if (!validatorsMigrated)
    {
        var validatorObject = new ObjectType
        {
            CanCustomize = false,
            CanSoftDelete = false,
            Description = "Validators object type",
            HasCustomFields = true,
            Display = "Validators",
            Name = "Validators",
            IsSystemModel = true,
            Properties = new List<ObjectProperty>
                        {
                            new ObjectProperty
                            {
                                Name = "Id",
                                Display = "Id",
                                DbTypeId = 1,
                                IsCustom = false,
                                IsPrimary = true,
                                Description = "Validators autoincrement identifier",
                                DefaultValue = String.Empty,
                                DisplayType = "Number"
                            },
                            new ObjectProperty
                            {
                                Name = "Name",
                                Display = "Name",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Validators Name",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                                PropertyValidators = new List<PropertyValidator>
                                {
                                    new PropertyValidator
                                    {
                                        ValidatorId = 1,
                                        ErrorMessage = "Name is required",
                                        ConstraintsJsonString = String.Empty
                                    }
                                }
                            },
                            new ObjectProperty
                            {
                                Name = "Display",
                                Display = "Display",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Validators Display",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                                PropertyValidators = new List<PropertyValidator>
                                {
                                    new PropertyValidator
                                    {
                                        ValidatorId = 1,
                                        ErrorMessage = "Display is required",
                                        ConstraintsJsonString= String.Empty
                                    }
                                }
                            },
                            new ObjectProperty
                            {
                                Name = "Description",
                                Display = "Description",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Validators Description",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                            },
                            new ObjectProperty
                            {
                                Name = "DefaultValuesJsonString",
                                Display = "DefaultValuesJsonString",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                IsNullable = true,
                                Description = "Validators Default Values Json String",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                            },
                            new ObjectProperty
                            {
                                Name = "DefaultValuesJsonString",
                                Display = "DefaultValuesJsonString",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                IsNullable = true,
                                Description = "Validators Default Values Json String",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                            },
                            new ObjectProperty
                            {
                                Name = "ParametersJsonString",
                                Display = "ParametersJsonString",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                IsNullable = true,
                                Description = "Validators Parameters Json String",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                            },
                            new ObjectProperty
                            {
                                Name = "CreatedBy",
                                Display = "Created By",
                                DbTypeId = 2, // Assuming string; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Creator of the Record",
                                DefaultValue = String.Empty,
                                DisplayType = "SingleSelect",
                            },
                            new ObjectProperty
                            {
                                Name = "CreationDate",
                                Display = "Creation Date",
                                DbTypeId = 7, // Assuming datetime; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Date of Record Creation",
                                DefaultValue = String.Empty,
                                DisplayType = "Date",
                            },
                            new ObjectProperty
                            {
                                Name = "ModificationDate",
                                Display = "Modification Date",
                                DbTypeId = 7, // Assuming datetime; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Date of Last Record Modification",
                                DefaultValue = String.Empty,
                                DisplayType = "Date",
                            },
                            new ObjectProperty
                            {
                                Name = "ModifiedBy",
                                Display = "Modified By",
                                DbTypeId = 2,IsCustom = false,
                                IsPrimary = false,
                                Description = "Identifier of Last Modifier",
                                DefaultValue = String.Empty,
                                DisplayType = "SingleSelect",
                            },
                        },
            CanAudit = true,
            PropertiesCount = 11
        };
        await _context.ObjectTypes.AddAsync(validatorObject);
        await _context.SaveChangesAsync();
    }
}
private async Task SeedPropertyValidatorsObject()
{
    var propertyValidatorsMigrated = await _context.ObjectTypes.AnyAsync(x => x.Name == "PropertyValidators");
    if (!propertyValidatorsMigrated)
    {
        var propertyValidatorObject = new ObjectType
        {
            CanCustomize = false,
            CanSoftDelete = false,
            Description = "Property validators object type",
            HasCustomFields = true,
            Display = "Property Validators",
            Name = "PropertyValidators",
            IsSystemModel = true,
            Properties = new List<ObjectProperty>
                        {
                            new ObjectProperty
                            {
                                Name = "Id",
                                Display = "Id",
                                DbTypeId = 1,
                                IsCustom = false,
                                IsPrimary = true,
                                Description = "Property validators autoincrement identifier",
                                DefaultValue = String.Empty,
                                DisplayType = "Number",
                            },
                            new ObjectProperty
                            {
                                Name = "PropertyId",
                                Display = "PropertyId",
                                DbTypeId = 1,
                                IsCustom = false,
                                IsPrimary = false,
                                IsForeign = true,
                                Description = "Property identifier",
                                DefaultValue = String.Empty,
                                DisplayType = "SingleSelect",
                                PropertyValidators = new List<PropertyValidator>
                                {
                                    new PropertyValidator
                                    {
                                        ValidatorId = 1,
                                        ErrorMessage = "Property is required",
                                        ConstraintsJsonString = String.Empty
                                    }
                                }
                            },
                            new ObjectProperty
                            {
                                Name = "ValidatorId",
                                Display = "ValidatorId",
                                DbTypeId = 1,
                                IsCustom = false,
                                IsPrimary = false,
                                IsForeign= true,
                                Description = "Validator identifier",
                                DefaultValue = String.Empty,
                                DisplayType = "SingleSelect",
                                PropertyValidators = new List<PropertyValidator>
                                {
                                    new PropertyValidator
                                    {
                                        ValidatorId = 1,
                                        ErrorMessage = "Validator is required",
                                        ConstraintsJsonString = String.Empty,
                                    }
                                }
                            },
                            new ObjectProperty
                            {
                                Name = "ConstraintsJsonString",
                                Display = "ConstraintsJsonString",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Propery validator constraints json string",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                            },
                            new ObjectProperty
                            {
                                Name = "ErrorMessage",
                                Display = "Error Message",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Propery validator Error message",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                            },
                            new ObjectProperty
                            {
                                Name = "CreatedBy",
                                Display = "Created By",
                                DbTypeId = 2, // Assuming string; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Creator of the Record",
                                DefaultValue = String.Empty,
                                DisplayType = "SingleSelect",
                            },
                            new ObjectProperty
                            {
                                Name = "CreationDate",
                                Display = "Creation Date",
                                DbTypeId = 7, // Assuming datetime; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Date of Record Creation",
                                DefaultValue = String.Empty,
                                DisplayType = "Date",
                            },
                            new ObjectProperty
                            {
                                Name = "ModificationDate",
                                Display = "Modification Date",
                                DbTypeId = 7, // Assuming datetime; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Date of Last Record Modification",
                                DefaultValue = String.Empty,
                                DisplayType = "Date",
                            },
                            new ObjectProperty
                            {
                                Name = "ModifiedBy",
                                Display = "Modified By",
                                DbTypeId = 2,IsCustom = false,
                                IsPrimary = false,
                                Description = "Identifier of Last Modifier",
                                DefaultValue = String.Empty,
                                DisplayType = "SingleSelect",
                            },
                        },
            CanAudit = true,
            PropertiesCount = 9
        };
        await _context.ObjectTypes.AddAsync(propertyValidatorObject);
        await _context.SaveChangesAsync();
    }
}
private async Task SeedObjectTypesObject()
{
    var objectTypeMigrated = await _context.ObjectTypes.AnyAsync(x => x.Name == "ObjectTypes");
    if (!objectTypeMigrated)
    {
        var objectTypesObject = new ObjectType
        {
            CanCustomize = false,
            CanSoftDelete = false,
            Description = "Object Types",
            HasCustomFields = true,
            Display = "Object Types",
            Name = "ObjectTypes",
            IsSystemModel = true,
            Properties = new List<ObjectProperty>
                        {
                            new ObjectProperty
                            {
                                Name = "Id",
                                Display = "Id",
                                DbTypeId = 1,
                                IsCustom = false,
                                IsPrimary = true,
                                Description = "Property validators autoincrement identifier",
                                DefaultValue = String.Empty,
                                DisplayType = "Number",
                            },
                            new ObjectProperty
                            {
                                Name = "Name",
                                Display = "Name",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Object Type Name",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                                PropertyValidators = new List<PropertyValidator>
                                {
                                    new PropertyValidator
                                    {
                                        ValidatorId = 1,
                                        ErrorMessage = "Name is required",
                                        ConstraintsJsonString = String.Empty
                                    }
                                }
                            },
                            new ObjectProperty
                            {
                                Name = "Display",
                                Display = "Display",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Object Type Display",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                                PropertyValidators = new List<PropertyValidator>
                                {
                                    new PropertyValidator
                                    {
                                        ValidatorId = 1,
                                        ErrorMessage = "Display is required",
                                        ConstraintsJsonString= String.Empty
                                    }
                                }
                            },
                            new ObjectProperty
                            {
                                Name = "Description",
                                Display = "Description",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                IsNullable = true,
                                Description = "Description",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                            },
                            new ObjectProperty
                            {
                                Name = "PropertiesCount",
                                Display = "Properties Count",
                                DbTypeId = 1,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Properties Count",
                                DefaultValue = String.Empty,
                                DisplayType = "Number",
                            },
                            new ObjectProperty
                            {
                                Name = "Version",
                                Display = "Version",
                                DbTypeId = 1,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Version",
                                DefaultValue = String.Empty,
                                DisplayType = "Number",
                            },
                            new ObjectProperty
                            {
                                Name = "IsSystemModel",
                                Display = "IsSystemModel",
                                DbTypeId = 6,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Properties Count",
                                DefaultValue = String.Empty,
                                DisplayType = "Checkbox",
                            },
                            new ObjectProperty
                            {
                                Name = "HasCustomFields",
                                Display = "Has Custom Fields",
                                DbTypeId = 6,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Has Custom Fields",
                                DefaultValue = String.Empty,
                                DisplayType = "Checkbox",
                            },
                            new ObjectProperty
                            {
                                Name = "CanCustomize",
                                Display = "Can Customize",
                                DbTypeId = 6,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Can Customize",
                                DefaultValue = String.Empty,
                                DisplayType = "Checkbox",
                            },
                            new ObjectProperty
                            {
                                Name = "CanSoftDelete",
                                Display = "Can Soft Delete",
                                DbTypeId = 6,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Can Soft Delete",
                                DefaultValue = String.Empty,
                                DisplayType = "Checkbox",
                            },
                            new ObjectProperty
                            {
                                Name = "CanAudit",
                                Display = "Can Audit",
                                DbTypeId = 6,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Can Audit",
                                DefaultValue = String.Empty,
                                DisplayType = "Checkbox",
                            },
                            new ObjectProperty
                            {
                                Name = "CreatedBy",
                                Display = "Created By",
                                DbTypeId = 2, // Assuming string; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Creator of the Record",
                                DefaultValue = String.Empty,
                                DisplayType = "SingleSelect",
                            },
                            new ObjectProperty
                            {
                                Name = "CreationDate",
                                Display = "Creation Date",
                                DbTypeId = 7, // Assuming datetime; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Date of Record Creation",
                                DefaultValue = String.Empty,
                                DisplayType = "Date",
                            },
                            new ObjectProperty
                            {
                                Name = "ModificationDate",
                                Display = "Modification Date",
                                DbTypeId = 7, // Assuming datetime; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Date of Last Record Modification",
                                DefaultValue = String.Empty,
                                DisplayType = "Date",
                            },
                            new ObjectProperty
                            {
                                Name = "ModifiedBy",
                                Display = "Modified By",
                                DbTypeId = 2,IsCustom = false,
                                IsPrimary = false,
                                Description = "Identifier of Last Modifier",
                                DefaultValue = String.Empty,
                                DisplayType = "SingleSelect",
                            },
                        },
            CanAudit = true,
            PropertiesCount = 15
        };
        await _context.ObjectTypes.AddAsync(objectTypesObject);
        await _context.SaveChangesAsync();
    }
}

private async Task SeedObjectPropertiesObject()
{
    var objectPropertiesMigrated = await _context.ObjectTypes.AnyAsync(x => x.Name == "ObjectProperties");
    if (!objectPropertiesMigrated)
    {
        var objectPropertieObject = new ObjectType
        {
            CanCustomize = false,
            CanSoftDelete = false,
            Description = "Object Properties",
            HasCustomFields = true,
            Display = "Object Properties",
            Name = "ObjectProperties",
            IsSystemModel = true,
            Properties = new List<ObjectProperty>
                        {
                            new ObjectProperty
                            {
                                Name = "Id",
                                Display = "Id",
                                DbTypeId = 1,
                                IsCustom = false,
                                IsPrimary = true,
                                Description = "Object properties autoincrement identifier",
                                DefaultValue = String.Empty,
                                DisplayType = "Number",
                            },
                            new ObjectProperty
                            {
                                Name = "Name",
                                Display = "Name",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Property Name",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                                PropertyValidators = new List<PropertyValidator>
                                {
                                    new PropertyValidator
                                    {
                                        ValidatorId = 1,
                                        ErrorMessage = "Name is required",
                                        ConstraintsJsonString = String.Empty
                                    }
                                }
                            },
                            new ObjectProperty
                            {
                                Name = "Display",
                                Display = "Display",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Display",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                                PropertyValidators = new List<PropertyValidator>
                                {
                                    new PropertyValidator
                                    {
                                        ValidatorId = 1,
                                        ErrorMessage = "Display is required",
                                        ConstraintsJsonString = String.Empty
                                    }
                                }

                            },
                            new ObjectProperty
                            {
                                Name = "Description",
                                Display = "Description",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                IsNullable = true,
                                Description = "Description",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                            },
                            new ObjectProperty
                            {
                                Name = "DefaultValue",
                                Display = "Default Value",
                                DbTypeId = 5,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Property Default Value",
                                DefaultValue = String.Empty,
                                DisplayType = "Text",
                            },
                            new ObjectProperty
                            {
                                Name = "DbTypeId",
                                Display = "Db Type Id",
                                DbTypeId = 1,
                                IsCustom = false,
                                IsPrimary = false,
                                IsForeign = true,
                                Description = "Db type identifier",
                                DefaultValue = String.Empty,
                                DisplayType = "SingleSelect",
                            },
                            new ObjectProperty
                            {
                                Name = "ObjectTypeId",
                                Display = "Object Type Id",
                                DbTypeId = 1,
                                IsCustom = false,
                                IsPrimary = false,
                                IsForeign = true,
                                Description = "Object type identifier",
                                DefaultValue = String.Empty,
                                DisplayType = "SingleSelect",
                            },
                            new ObjectProperty
                            {
                                Name = "DbTypeLength",
                                Display = "Db Type Length",
                                DbTypeId = 1,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Db Type Length",
                                DefaultValue = String.Empty,
                                DisplayType = "Number",
                            },
                            new ObjectProperty
                            {
                                Name = "IsCustom",
                                Display = "Is Custom",
                                DbTypeId = 6,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Is custom property",
                                DefaultValue = String.Empty,
                                DisplayType = "Checkbox",
                            },
                            new ObjectProperty
                            {
                                Name = "IsPrimary",
                                Display = "Is Primary",
                                DbTypeId = 6,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Is primary property",
                                DefaultValue = String.Empty,
                                DisplayType = "Checkbox",
                            },
                            new ObjectProperty
                            {
                                Name = "IsUnique",
                                Display = "Is Unique",
                                DbTypeId = 6,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Is unique property",
                                DefaultValue = String.Empty,
                                DisplayType = "Checkbox",
                            },
                            new ObjectProperty
                            {
                                Name = "IsNullable",
                                Display = "Is Nullable",
                                DbTypeId = 6,
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Is nullable property",
                                DefaultValue = String.Empty,
                                DisplayType = "Checkbox",
                            },
                            new ObjectProperty
                            {
                                Name = "AsForeignKey",
                                Display = "As ForeignKey",
                                DbTypeId = 1, // Assuming string; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "As foreign key property",
                                DefaultValue = String.Empty,
                                DisplayType = "Number",
                            },
                            new ObjectProperty
                            {
                                Name = "IsForeign",
                                Display = "Is Foreign",
                                DbTypeId = 1, // Assuming string; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Is foreign key property",
                                DefaultValue = String.Empty,
                                DisplayType = "Checkbox",
                            },
                            new ObjectProperty
                            {
                                Name = "ForeignKeyObjectTypeId",
                                Display = "ForeignKey ObjectType Id",
                                DbTypeId = 1, // Assuming string; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "ForeignKey ObjectType identifier",
                                DefaultValue = String.Empty,
                                DisplayType = "Number",
                            },
                            new ObjectProperty
                            {
                                Name = "ForeignKeyPropertyId",
                                Display = "ForeignKey Property Id",
                                DbTypeId = 1, // Assuming string; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "ForeignKey Property identifier",
                                DefaultValue = String.Empty,
                                DisplayType = "Number",
                            },
                            new ObjectProperty
                            {
                                Name = "CreatedBy",
                                Display = "Created By",
                                DbTypeId = 2, // Assuming string; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Creator of the Record",
                                DefaultValue = String.Empty,
                                DisplayType = "SingleSelect",
                            },
                            new ObjectProperty
                            {
                                Name = "CreationDate",
                                Display = "Creation Date",
                                DbTypeId = 7, // Assuming datetime; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Date of Record Creation",
                                DefaultValue = String.Empty,
                                DisplayType = "Date",
                            },
                            new ObjectProperty
                            {
                                Name = "ModificationDate",
                                Display = "Modification Date",
                                DbTypeId = 7, // Assuming datetime; adjust as needed
                                IsCustom = false,
                                IsPrimary = false,
                                Description = "Date of Last Record Modification",
                                DefaultValue = String.Empty,
                                DisplayType = "Date",
                            },
                            new ObjectProperty
                            {
                                Name = "ModifiedBy",
                                Display = "Modified By",
                                DbTypeId = 2,IsCustom = false,
                                IsPrimary = false,
                                Description = "Identifier of Last Modifier",
                                DefaultValue = String.Empty,
                                DisplayType = "SingleSelect",
                            },
                        },
            CanAudit = true,
            PropertiesCount = 20
        };
        await _context.ObjectTypes.AddAsync(objectPropertieObject);
        await _context.SaveChangesAsync();
    }
}

private async Task SeedTranslationsObject()
{
    var translationsMigrated = await _context.ObjectTypes.AnyAsync(x => x.Name == "Translations");

    if (!translationsMigrated)
    {
        var translationsObject = new ObjectType
        {
            Name = "Translations",
            Display = "Translations",
            CanAudit = true,
            CanSoftDelete = false,
            CanCustomize = false,
            Description = "Translations object type",
            HasCustomFields = true,
            IsSystemModel = true,
            PropertiesCount = 8,
            Properties = new List<ObjectProperty>()
                    {
                        new ObjectProperty
                        {
                            Name = "Id",
                            Display = "Id",
                            DbTypeId = 2,
                            IsCustom = false,
                            IsPrimary = true,
                            Description ="Translations autoincrement identifier",
                            DefaultValue = String.Empty,
                            DisplayType = "Number",

                        },
                        new ObjectProperty
                        {
                            Name = "SourceLanguage",
                            Display = "Source Language",
                            DbTypeId = 5,
                            IsCustom = false,
                            IsPrimary = false,
                            Description ="Translation Text Source Language",
                            DefaultValue = String.Empty,
                            DisplayType = "Text",
                        },
                        new ObjectProperty
                        {
                            Name = "SourceLanguageName",
                            Display = "Source Language Name",
                            DbTypeId = 5,
                            IsCustom = false,
                            IsPrimary = false,
                            Description ="Translation Text Source Language Name",
                            DefaultValue = String.Empty,
                            DisplayType = "Text",
                        },
                        new ObjectProperty
                        {
                            Name = "Text",
                            Display = "Text",
                            DbTypeId = 5,
                            IsCustom = false,
                            IsPrimary = false,
                            Description ="Text",
                            DefaultValue = String.Empty,
                            DisplayType = "Text",
                        },
                        new ObjectProperty
                        {
                            Name = "Text",
                            Display = "Text",
                            DbTypeId = 5,
                            IsCustom = false,
                            IsPrimary = false,
                            Description ="Text",
                            DefaultValue = String.Empty,
                            DisplayType = "Text",
                        },
                        new ObjectProperty
                        {
                            Name = "TranslatedText",
                            Display = "Translated Text",
                            DbTypeId = 5, // Assuming string; adjust as needed
                            IsCustom = false,
                            IsPrimary = false,
                            Description = "Translated Text",
                            DefaultValue = String.Empty,
                            DisplayType = "Text",
                        },
                        new ObjectProperty
                        {
                            Name = "CreationDate",
                            Display = "Creation Date",
                            DbTypeId = 7, // Assuming datetime; adjust as needed
                            IsCustom = false,
                            IsPrimary = false,
                            Description = "Date of Record Creation",
                            DefaultValue = String.Empty,
                            DisplayType = "Date",
                        },
                        new ObjectProperty
                        {
                            Name = "CreatedBy",
                            Display = "Created By",
                            DbTypeId = 2, // Assuming string; adjust as needed
                            IsCustom = false,
                            IsPrimary = false,
                            Description = "Creator of the Record",
                            DefaultValue = String.Empty,
                            DisplayType = "SingleSelect",
                        },
                        new ObjectProperty
                        {
                            Name = "ModificationDate",
                            Display = "Modification Date",
                            DbTypeId = 7, // Assuming datetime; adjust as needed
                            IsCustom = false,
                            IsPrimary = false,
                            Description = "Date of Last Record Modification",
                            DefaultValue = String.Empty,
                            DisplayType = "Date",
                        },
                        new ObjectProperty
                        {
                            Name = "ModifiedBy",
                            Display = "Modified By",
                            DbTypeId = 2,
                            IsCustom = false,
                            IsPrimary = false,
                            Description = "Identifier of Last Modifier",
                            DefaultValue = String.Empty,
                            DisplayType = "SingleSelect",
                        },
                    },
        };

        await _context.ObjectTypes.AddAsync(translationsObject);
        await _context.SaveChangesAsync();
    }
}
