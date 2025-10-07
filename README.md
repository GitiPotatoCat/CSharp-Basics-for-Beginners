# CSharp-Basics-for-Beginners
C# Basics for Beginners: Learn C# Fundamentals by Coding



### Primitive Types

#### Integral Numbers
| C# Type | .NET Type | Bytes | Range |
|---------|-----------|--------|--------|
| `sbyte` | System.SByte | 1 | -128 to 127 |
| `byte` | System.Byte | 1 | 0 to 255 |
| `short` | System.Int16 | 2 | -32,768 to 32,767 |
| `ushort` | System.UInt16 | 2 | 0 to 65,535 |
| `int` | System.Int32 | 4 | -2.1B to 2.1B |
| `uint` | System.UInt32 | 4 | 0 to 4.2B |
| `long` | System.Int64 | 8 | -9.2E to 9.2E |
| `ulong` | System.UInt64 | 8 | 0 to 18.4E |

#### Real Numbers
| C# Type | .NET Type | Bytes | Range |
|---------|-----------|--------|--------|
| `float` | System.Single | 4 | ±1.5 × 10^-45 to ±3.4 × 10^38 |
| `double` | System.Double | 8 | ±5.0 × 10^-324 to ±1.7 × 10^308 |
| `decimal` | System.Decimal | 16 | ±1.0 × 10^-28 to ±7.9 × 10^28 |

#### Character
| C# Type | .NET Type | Bytes | Range |
|---------|-----------|--------|--------|
| `char` | System.Char | 2 | U+0000 to U+FFFF |

#### Boolean
| C# Type | .NET Type | Bytes | Range |
|---------|-----------|--------|--------|
| `bool` | System.Boolean | 1 | true or false |



### Non-Primitive Types

In C#, non-primitive types are more complex data types that are either built into the language or created by the programmer. Here are the main categories:

1. **String**
   - Type: `string` (System.String)
   - Reference type for text
   - Immutable sequence of Unicode characters

2. **Array**
   - Fixed-size collection of elements
   - Can be single-dimensional, multi-dimensional, or jagged
   - Example: `int[]`, `string[]`, `int[,]`, `int[][]`

3. **Class**
   - User-defined reference type
   - Can contain data and methods
   - Supports inheritance and polymorphism
   - Example: `class Person { }`

4. **Interface**
   - Contract that defines a set of members
   - Can be implemented by classes and structs
   - Example: `interface IShape { }`

5. **Structure (struct)**
   - Value type that can contain data and methods
   - Lightweight alternative to classes
   - Example: `struct Point { }`

6. **Enum**
   - Value type for a set of named constants
   - Example: `enum DaysOfWeek { }`

7. **Delegate**
   - Type for storing method references
   - Used for events and callbacks
   - Example: `delegate void MessageHandler(string message);`

8. **Tuple**
   - Groups multiple data elements
   - Example: `(string, int)` or `ValueTuple<string, int>`

9. **Record** (C# 9.0+)
   - Immutable by default
   - Built-in value equality
   - Example: `record Person(string Name, int Age);`

10. **Dynamic**
    - Type checked at runtime
    - Late binding support
    - Example: `dynamic obj = new ExpandoObject();`
