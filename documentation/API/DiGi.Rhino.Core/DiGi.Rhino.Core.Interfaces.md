#### [DiGi\.Rhino\.Core](index.md 'index')

## DiGi\.Rhino\.Core\.Interfaces Namespace
### Interfaces

<a name='DiGi.Rhino.Core.Interfaces.IComponent'></a>

## IComponent Interface

Defines the contract for components within the DiGi Rhino framework, extending the base [Grasshopper\.Kernel\.IGH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_component 'Grasshopper\.Kernel\.IGH\_Component')\.

```csharp
public interface IComponent
```

<a name='DiGi.Rhino.Core.Interfaces.IGooObject'></a>

## IGooObject Interface

Defines the base interface for all Goo objects within the DiGi Rhino core, extending Grasshopper's [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')\.

```csharp
public interface IGooObject
```

Derived  
↳ [GooEnum&lt;T&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooEnum_T_ 'DiGi\.Rhino\.Core\.Classes\.GooEnum\<T\>')  
↳ [GooObject&lt;TObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')  
↳ [GooSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')  
↳ [GooType](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooType 'DiGi\.Rhino\.Core\.Classes\.GooType')  
↳ [IGooObject&lt;TObject&gt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>')  
↳ [IGooSerializableObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject')  
↳ [IGooSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject\<TSerializableObject\>')

<a name='DiGi.Rhino.Core.Interfaces.IGooObject_TObject_'></a>

## IGooObject\<TObject\> Interface

Defines a generic Goo object that wraps a value of type [TObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_.TObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>\.TObject')\.

```csharp
public interface IGooObject<TObject> : DiGi.Rhino.Core.Interfaces.IGooObject
```
#### Type parameters

<a name='DiGi.Rhino.Core.Interfaces.IGooObject_TObject_.TObject'></a>

`TObject`

The type of the underlying data wrapped by the Goo object\.

Derived  
↳ [GooObject&lt;TObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooObject_TObject_ 'DiGi\.Rhino\.Core\.Classes\.GooObject\<TObject\>')  
↳ [GooSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')  
↳ [GooType](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooType 'DiGi\.Rhino\.Core\.Classes\.GooType')  
↳ [IGooSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject\<TSerializableObject\>')

Implements [IGooObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject')
### Properties

<a name='DiGi.Rhino.Core.Interfaces.IGooObject_TObject_.Value'></a>

## IGooObject\<TObject\>\.Value Property

Gets the underlying value contained within the Goo object\.

```csharp
TObject? Value { get; }
```

#### Property Value
[TObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_.TObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>\.TObject')
### Methods

<a name='DiGi.Rhino.Core.Interfaces.IGooObject_TObject_.GetValue_XObject_()'></a>

## IGooObject\<TObject\>\.GetValue\<XObject\>\(\) Method

Retrieves the underlying value cast to a specific type [XObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_.GetValue_XObject_().XObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>\.GetValue\<XObject\>\(\)\.XObject')\.

```csharp
XObject? GetValue<XObject>()
    where XObject : TObject;
```
#### Type parameters

<a name='DiGi.Rhino.Core.Interfaces.IGooObject_TObject_.GetValue_XObject_().XObject'></a>

`XObject`

The target type to retrieve the value as, which must derive from [TObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_.TObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>\.TObject')\.

#### Returns
[XObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_.GetValue_XObject_().XObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>\.GetValue\<XObject\>\(\)\.XObject')  
The value cast to [XObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_.GetValue_XObject_().XObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>\.GetValue\<XObject\>\(\)\.XObject'), or null if the cast is not possible or the value is null\.

<a name='DiGi.Rhino.Core.Interfaces.IGooSerializableObject'></a>

## IGooSerializableObject Interface

Defines a contract for an object that is both a Goo object and serializable\.

```csharp
public interface IGooSerializableObject : DiGi.Rhino.Core.Interfaces.IGooObject
```

Derived  
↳ [GooSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')  
↳ [IGooSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject\<TSerializableObject\>')

Implements [IGooObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject')

<a name='DiGi.Rhino.Core.Interfaces.IGooSerializableObject_TSerializableObject_'></a>

## IGooSerializableObject\<TSerializableObject\> Interface

Defines a generic contract for an object that is both a Goo object and serializable, associated with a specific serializable object type\.

```csharp
public interface IGooSerializableObject<TSerializableObject> : DiGi.Rhino.Core.Interfaces.IGooSerializableObject, DiGi.Rhino.Core.Interfaces.IGooObject, DiGi.Rhino.Core.Interfaces.IGooObject<TSerializableObject?>
    where TSerializableObject : DiGi.Core.Interfaces.ISerializableObject
```
#### Type parameters

<a name='DiGi.Rhino.Core.Interfaces.IGooSerializableObject_TSerializableObject_.TSerializableObject'></a>

`TSerializableObject`

The type of the serializable object\. Must implement [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.

Derived  
↳ [GooSerializableObject&lt;TSerializableObject&gt;](DiGi.Rhino.Core.Classes.md#DiGi.Rhino.Core.Classes.GooSerializableObject_TSerializableObject_ 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\<TSerializableObject\>')

Implements [IGooSerializableObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject'), [IGooObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject'), [DiGi\.Rhino\.Core\.Interfaces\.IGooObject&lt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>')[TSerializableObject](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooSerializableObject_TSerializableObject_.TSerializableObject 'DiGi\.Rhino\.Core\.Interfaces\.IGooSerializableObject\<TSerializableObject\>\.TSerializableObject')[&gt;](DiGi.Rhino.Core.Interfaces.md#DiGi.Rhino.Core.Interfaces.IGooObject_TObject_ 'DiGi\.Rhino\.Core\.Interfaces\.IGooObject\<TObject\>')