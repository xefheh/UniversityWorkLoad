using System.CodeDom;

namespace UniversityWorkLoad.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class DbMethod : Attribute
{
    public readonly Type Type;

    public DbMethod(Type type) => Type = type;
}

[AttributeUsage(AttributeTargets.Method)]
public sealed class DbAddMethod : DbMethod { public DbAddMethod(Type type) : base(type) { } }

[AttributeUsage(AttributeTargets.Method)]
public sealed class DbRemoveMethod : DbMethod { public DbRemoveMethod(Type type) : base(type) { } }

[AttributeUsage(AttributeTargets.Method)]
public sealed class DbGetAllMethod : DbMethod { public DbGetAllMethod(Type type) : base(type) { } }


[AttributeUsage(AttributeTargets.Method)]
public sealed class DbGetMethod : DbMethod { public DbGetMethod(Type type) : base(type) { } }


[AttributeUsage(AttributeTargets.Method)]
public sealed class DbUpdateMethod : DbMethod { public DbUpdateMethod(Type type) : base(type) { } }

public sealed class DbGetByFilter : DbMethod { public DbGetByFilter(Type type) : base(type) { } }

[AttributeUsage(AttributeTargets.Class)]
public class DbObjectForm : Attribute
{
    public readonly Type Type;

    public DbObjectForm(Type type) => Type = type;
}

[AttributeUsage(AttributeTargets.Class)]
public sealed class DbSimpleForm : DbObjectForm { public DbSimpleForm(Type type) : base(type) { } }

[AttributeUsage(AttributeTargets.Class)]
public sealed class DbComplexForm : DbObjectForm { public DbComplexForm(Type type) : base(type) { } }


[AttributeUsage(AttributeTargets.Method)]
public class RepositoryMethod : Attribute { }

[AttributeUsage(AttributeTargets.Method)]
public class RepositoryAddMethod : RepositoryMethod { }

[AttributeUsage(AttributeTargets.Method)]
public class RepositoryRemoveMethod : RepositoryMethod { }

[AttributeUsage(AttributeTargets.Method)]
public class RepositoryGetAllMethod : RepositoryMethod { }

[AttributeUsage(AttributeTargets.Method)]
public class RepositoryGetMethod : RepositoryMethod { }

[AttributeUsage(AttributeTargets.Class)]
public sealed class DataFormatter : Attribute
{
    public readonly Type Type;

    public DataFormatter(Type type) => Type = type;
}

[AttributeUsage(AttributeTargets.Method)]
public sealed class ComplexPart : Attribute
{
    public readonly Type Type;

    public ComplexPart(Type type) => Type = type;
}

[AttributeUsage(AttributeTargets.Property)]
public sealed class FilterCriteria : Attribute { }