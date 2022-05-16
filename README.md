# dotnet-mvc-sample
.net mvc 공홈 자습서 샘플

매번 자바 스프링만 작업하다가 C#/.net 환경 공부가 필요해서 
공홈 자습서 따라한 프로젝트
MVC + Razor로 구성된 Page 환경에 EF기본이 적용되어있음

- C# 10
- .net Core 6.0
- MVC webapp

```bash
#EF Core SQL Server 공급자. 이 공급자 패키지는 EF Core 패키지를 종속성으로 설치합니다.
#패키지에 사용되는 유틸리티(자습서 뒷부분의 스캐폴딩 단계에서 자동으로 설치됨).
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.EntityFrameworkCore.SqlServer

#마이그레이션 파일 생성 및 DB 업데이트
Add-Migration [Migration_File_name]
Update-Database

```
