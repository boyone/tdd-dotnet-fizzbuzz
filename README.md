# TDD dotnet FizzBuzz

1. สร้าง Solution File ไปที่ Folder FizzBuzz ถ้าไม่มี Folder นี้อยู่ ตัว Command จะสร้างให้อัตโนมัติ

   ```sh
   dotnet new sln -o FizzBuzz
   ```

2. Change Directory ไปที่ FizzBuzz

   ```sh
   cd FizzBuzz
   ```

3. สร้างโปรเจ็ค FizzBuzz.Tests โดยใช้ Template ของ xunit

   ```sh
   dotnet new xunit -o FizzBuzz.Tests
   ```

4. Rename and Implement Test Code

   ```csharp
   mv FizzBuzz.Tests/UnitTest1.cs FizzBuzz.Tests/FizzBuzzTest.cs
   ```

   ```csharp
   namespace FizzBuzz.Tests;

   public class FizzBuzzTest
   {
       [Fact]
       public void Number_1_Should_Say_1()
       {
           // Arrange
           var expectedResult = "1";
           var fizzBuzz = new FizzBuzz();

           // Act
           var actualResult = fizzBuzz.Say(1);

           // Assert
           Assert.Equal(expectedResult, actualResult);
       }
   }
   ```

5. Run Test

   ```sh
   dotnet test
   ```

   - จะได้ `warning` ที่บอกว่าไม่เจอโปรเจ็ค

   ```sh
   /path to/dotnet/sdk/6.0.400/NuGet.targets(132,5): warning : Unable to find a project to restore! [/path to/FizzBuzz/FizzBuzz.sln]
   ```

6. Add FizzBuzz.Tests โปรเจ็คเข้า Solution File

   ```sh
   dotnet sln add ./FizzBuzz.Tests/FizzBuzz.Tests.csproj
   ```

7. Run Test

   ```sh
   dotnet test
   ```

   - จะได้ `error message`

   ```sh
   /path to/FizzBuzz/FizzBuzz.Tests/FizzBuzzTest.cs(10,28): error CS0118: 'FizzBuzz' is a namespace but is used like a type [/path to/FizzBuzz/FizzBuzz.Tests/FizzBuzz.Tests.csproj]
   ```

8. สร้างโปรเจ็ค FizzBuzz โดยใช้ Template ของ classlib

   ```sh
   dotnet new classlib -o FizzBuzz
   ```

9. Add FizzBuzz โปรเจ็คเข้า Solution File

   ```sh
   dotnet sln add ./FizzBuzz/FizzBuzz.csproj
   ```

10. Rename

    ```csharp
    mv FizzBuzz/Class1.cs FizzBuzz/FizzBuzz.cs
    ```

11. Add Reference ระหว่าง FizzBuzz.Tests และ FizzBuzz โปรเจ็ค

    ```sh
    dotnet add ./FizzBuzz.Tests/FizzBuzz.Tests.csproj reference ./FizzBuzz/FizzBuzz.csproj
    ```

12. Implement Production Code

    ```csharp
    namespace FizzBuzz;
    public class FizzBuzz
    {
        public string Say(int number)
        {
            return "1";
        }
    }
    ```

13. Run Test

    ```sh
    dotnet test
    ```
