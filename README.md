TOEIC Management Program (토익 수강생 관리 프로그램) 
=============
* C# 수업에서 1인으로 수행한 프로젝트입니다.(2022.8 - 2022.12)

<br>목차
-------------
- [TOEIC Management Program (토익 수강생 관리 프로그램)](#toeic-management-program-토익-수강생-관리-프로그램)
  - [목차](#목차)
  - [프로젝트 개요](#프로젝트-개요)
  - [사용 스킬](#사용-스킬)
  - [기능 소개](#기능-소개)
  - [구현 이미지](#구현-이미지)


## <br>프로젝트 개요
* **C# .NET을 이용한 토익 수강생 관리 프로그램** 기능 구현을 목표로 하였습니다.
* 윈도우 프로그래밍 수업에서 만든 간단한 토이 프로젝트입니다.
* TOEIC 학원 수강생들을 데이터베이스를 이용해 쉽게 관리, 추가, 삭제를 할 수 있습니다.
* 성적 부실 학생을 조회할 수 있습니다.
* 달마다 토익 문제를 업데이트하여 토익 문제를 풀 수 있습니다.
* 토익 사이트를 포털사이트를 걸치거나, 사이트 URL을 별도로 입력하지 않고 사이트버튼의 로고를 클릭하면 이동할 수 있게 하도록 하였습니다
* 토익 일정을 데이터베이스에 추가하여 오늘 날짜를 입력하면 D-DAY를 계산해주어서 토익 일정을 손쉽게 확인하고, 이에 맞춰 토익을 준비할 수 있도록 하였습니다. 

## 기능 소개

1. 시작화면에서 수강생 목록을 한 눈에 쉽게 볼 수 있습니다.
2. 수강생 등록, 조회, 삭제를 할 수 있습니다.
3. 성적 부실 학생과 성적 우수 학생을 확인 할 수 있게 하여 선생님들이 학생 지도를 더 원활하게 할 수 있게 하였습니다.
4. 점수별 통계를 내어 점수대별 학생을 손쉽게 볼 수 있습니다.
5. 예상 문제로 학생들을 test할 수 있게 하였습니다.
6. 토익 일정을 추가, 삭제, 수정 할 수 있고 오늘 날짜를 기반으로 d-day를 볼 수 있게 하였습니다.
7. 토익 관련 사이트에 손쉽게 이동할 수 있도록 하였습니다.
   
## 사용 스킬

* C#
* .NET
* MS SQL Server
  
## 구현 이미지 

|초기화면|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/effc1031-c1b0-46d2-a95b-222186cc3043)|
|수강생 관리, 학생관리 메뉴가 있고 예상 LC,RC문제를 풀 수 있는 버튼,토익 일정 조회 버튼, 관련 사이트 버튼, 조회 버튼이 있습니다.
초기 화면에서도 등록 학생들을 볼 수 있도록 그리드뷰를 배치해 놓았습니다.
수강생 추가 후 새로고침 버튼을 누르면 학생이 추가된 그리드뷰를 조회 할 수 있습니다.|

<br>

|수강생관리 메뉴 –수강생 등록,수정,삭제,조회(초기화면)|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/f7bb4ab7-80c3-47f9-997a-2bfad6cb711e)|
|이름, 나이, 전화번호, 학교, 주소, 목표점수, 모의고사 점수, 수강반, 입학번호, 등록날짜, 수강비, 경성대 재학생 체크 유무 칸이 있습니다
무조건 입학번호 생성 키를 눌러서 기본키를 생성해줘야합니다. 입학번호는 입력한 전화번호의 뒷자리 4개입니다. 목표점수 콤보박스에서 선택한 점수에 따라 수강반, 수강비가 자동 입력되고, 경성대 재학생 체크박스를 체크하면 할인이 적용됩니다. 등록, 수정, 삭제, 조회 버튼을 배치하여 데이터베이스에 접근 할 수 있게 하였습니다. |


<br>

|수강생관리 메뉴 –수강생 등록,수정,삭제,조회(등록)|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/a4edf6cd-8520-4b69-9cea-4ca6deb890d1)|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/e4b361cd-9a87-4bad-8fc1-aaa447705536)|
|이와 같은 내용으로 등록을 해보았습니다. 입학번호 생성 버튼을 눌러 입학번호를 생성해주었고 800+로 목표점수를 설정하여 자동으로 수강반과 수강비가 입력되었습니다. 또한 학교가 경성대이므로 경성대 체크박스에 체크를 해주어 할인을 적용하였습니다. 그리고 성공적으로 데이터가 데이터베이스(TBstudent)에 들어간 것을 확인 할 수 있습니다.|

<br>

|수강생관리 메뉴 –수강생 등록,수정,삭제,조회(수정))|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/31a3f017-f8e7-4bd8-aa7a-4b5e6b1b6412)|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/42781f82-d65a-4116-b80c-ad556030db12)|
|주소를 남구로 수정을 해보았습니다. 그리고 성공적으로 수정된 데이터가 데이터베이스(TBstudent)에 들어간 것을 확인 할 수 있습니다.|

<br>

|수강생관리 메뉴 –수강생 등록,수정,삭제,조회(조회))|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/f10997b7-19ea-462f-9b6c-a746bc7c2fa9)|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/be21758c-234e-418d-8ec7-29f8b6126c0e)|
|입학번호에 5000을 입력하고 조회버튼을 누르자 관련 텍스트박스와 콤보박스가 해당 자료로 설정된 것을 볼 수 있습니다.|

<br>

|수강생관리 메뉴 –수강생 등록,수정,삭제,조회(삭제)|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/ce1f9095-cde4-46ae-b83e-5f4426f0caa5)|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/821fbbe8-e4c4-4e6c-aa1c-8c1b85ba5ae5)|
|입학번호에 5000을 입력하고 삭제버튼을 눌렀습니다. 테스트 학생이 정상적으로 삭제 된 것을 확인할 수 있습니다. |


<br>

|성적관리 탭 -초기화면|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/602a97a3-bfd9-4d5d-90e2-b59c8f69c745)|
|그리드뷰를 이용하여 전체 학생을 볼 수 있고 성적부실 학생조회 버튼, 성적우수 학생조회 버튼, 전체학생 조회 버튼, 종료 버튼을 배치하였습니다.
전화번호나,주소 등을 제외한 핵심 데이터인 목표점수, 모의고사 점수, 수강반만을 표시하였습니다.|


<br>

|성적관리 탭 –성적부실 학생조회 버튼 클릭|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/9e85b4cd-ca4b-41aa-858d-6fc839c7d7ae)|
|성적부실의 기준점은 600점 이하입니다.
600점 이하의 학생을 오름차순으로 정렬하여 출력하였습니다.|


<br>

|성적관리 탭 –전체 학생조회 버튼 클릭|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/99129b41-8b4c-4cbe-8e21-8d1802a85b79)|
|전체 학생 조회 버튼을 클릭하면 다시 초기화면처럼 전체 학생 목록을 그리드뷰에 출력합니다.|

<br>

|성적관리 탭 –성적우수 학생조회 버튼 클릭|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/8b61f0b6-57fb-4d31-bdf8-ba738feaad1a)|
|성적우수의 기준점은 800점 이상입니다.
800점 이상의 학생을 오름차순으로 정렬하여 출력하였습니다.|

<br>

|학생개인관리 메뉴- 점수별 통계 탭 초기화면|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/10562c18-f25b-4ab2-840d-27c346004996)|
|모의고사를 기반으로 하여 점수별로 학생들을 볼 수 있게 하였습니다. 버튼을 클릭하면 해당 점수대의 학생 목록을 그리드뷰에 출력합니다. 
이도 핵심 정보인 ID,이름,목표점수,모의고사점수,수강반만을 출력합니다.|

<br>

|학생개인관리 메뉴- 점수별 통계 탭 600점이하 버튼 클릭|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/3b8bb044-66df-46e3-a3fc-f91503ae4b4b)|
|버튼을 클릭하면 600점이하 모의고사 점수대의 학생들을 그리드뷰에 출력합니다.|

<br>

|학생개인관리 메뉴-학생개인관리 메뉴- 점수별 통계 탭 600점대 버튼 클릭|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/091183f1-b71d-4487-b24e-24e51d325adc)|
|버튼을 클릭하면 600점대 모의고사 점수대의 학생들을 그리드뷰에 출력합니다.
600점대 모의고사 점수를 가진 학생이 아무도 없어 그리드뷰에 공백이 출력됨을 볼 수 있습니다.|

<br> 

|학생개인관리 메뉴- 점수별 통계 탭 700점대 버튼 클릭|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/91355f68-835d-4c4a-ba0b-44f4e04e03b5)|
|버튼을 클릭하면 700점대 모의고사 점수대의 학생들을 그리드뷰에 출력합니다.|

<br> 

|학생개인관리 메뉴- 점수별 통계 탭 800점대 버튼 클릭|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/9ecc821b-10b2-4051-b035-859722db550c)|
|버튼을 클릭하면 800점대 모의고사 점수대의 학생들을 그리드뷰에 출력합니다.|

<br> 

|학생개인관리 메뉴- 점수별 통계 탭 900점대 버튼 클릭|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/cbcce024-b082-41b2-b8f1-59482bd8da77)|
|버튼을 클릭하면 900점대 모의고사 점수대의 학생들을 그리드뷰에 출력합니다.|

<br> 

|학생개인관리 메뉴- 점수별 통계 탭 전체보기 버튼 클릭|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/5ad37db2-dc37-4bac-8562-9883665e8baf)|
|전체를 출력하는 그리드뷰를 보여줍니다.|


<br> 

|6월 예상 LC 문제 버튼 클릭  - 초기화면 |
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/c9f486a8-c061-4d40-a110-c66fe283e0ec)|
|6월 LC 예상 문제를 체크박스로 표현했습니다. 정답확인 버튼을 누르면 체크한 답이 정답인지 오답인지를 메시지박스로 알려줍니다.|

<br> 

|6월 예상 LC 문제 버튼 클릭  - 오답 |
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/af6367f4-dd20-4c91-88dd-38d2a8adf680)|

<br> 

|6월 예상 LC 문제 버튼 클릭  - 정답 |
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/809b90ab-7071-4b93-85f5-3a0ac37c2cb5)|

<br> 

|6월 예상 RC 문제 버튼 클릭  - 초기화면  |
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/8cbf9404-7ed9-4c7e-a057-0db6715ec1e4)|
|6월 RC 예상 문제를 체크박스로 표현했습니다. 정답확인 버튼을 누르면 체크한 답이 정답인지 오답인지를 메시지박스로 알려줍니다.|

<br> 

|6월 예상 RC 문제 버튼 클릭  - 정답  |
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/fd8f82f2-b3de-4a28-bc49-3ba6c20b5b8d)|

<br> 

|6월 예상 RC 문제 버튼 클릭  - 오답  |
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/08bf47c5-03ff-4999-b308-ca9261abcc49)|


<br> 

|조회업무 버튼 클릭 – 초기화면|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/71205d9e-2344-4f69-96e0-84e939394f4f)|
|그리드뷰에 전체 학생들이 다 보입니다. 휴대전화 뒷번호 4자리로 학생정보를 확인후 수정/삭제 페이지로 바로 이동할 수 있게 하였습니다.|

<br> 

|조회업무 버튼 클릭 – 조회 버튼 |
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/a0485660-b974-4e96-aa85-e6ce8fc3de19)|
|텍스트박스에 휴대전화 뒷자리 4개를 입력하고 조회버튼을 클릭하면 해당 학생의 정보가 출력됩니다.|


<br> 

|조회업무 버튼 클릭 – 전체보기 버튼 |
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/99631cb2-5757-40db-90a5-cdd0c25fea25)|
|전체보기 버튼을 누르면 다시 전체 학생의 정보가 출력됩니다.|



<br> 

|조회업무 버튼 클릭 – 수정/삭제 페이지로 이동 버튼 |
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/1b045b0c-5856-43e2-882f-de4f37669b5d)|
|수정/삭제 페이지로 이동 버튼을 누르면 입학원서 폼이 나오면서 학생정보 수정/삭제를 수월하게끔 하였습니다.|


<br> 

|TOEIC 시험 일정버튼 클릭 – 초기화면 |
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/1bb22da4-a154-4882-b103-b0230b8ae5d9)|
|시험일자,오늘일자를 입력할 수 있게하였고 날짜등록,D-Day변경,날짜 삭제,새로고침 버튼을 넣었습니다. 조회하는 날짜에 맞춰 D-Day를 변경하고 시험날짜를 삭제할 수 있게 하였습니다.
새로고침을 하면 수정된 데이터를 바로 확인할 수 있습니다.|

<br>

|TOEIC 시험 일정버튼 클릭 – 날짜등록|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/6872b713-3a46-4410-bd0e-fb5becb20f3b)|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/e8a44077-c369-41b6-9273-3e67d54586c7)|
|시험일자, 오늘일자를 입력하고 날짜등록 버튼을 누르면 시험일정,자동으로 계산된 d-day가 TBdate에 삽입됩니다. 20210826(시험날짜)와 오늘 날짜인 20210612를 선택하였고 화면에서 새로고침 버튼을 눌러 그리드뷰를 다시 조회하니 ID가 826(월,일)로 정상적으로 등록된 것을 볼 수 있습니다. |

<br>

|TOEIC 시험 일정버튼 클릭 – Dday 변경|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/e42d0836-95d9-4fde-b6a5-42a60703ee47)|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/2a6c38da-5eb7-4c65-b03e-84f2f022c108)|
|옆의 그리드뷰에서 시험일자를 확인하고 시험일자를 입력 후 오늘 날짜를 다시 입력하고 D-Day변경 버튼을 누르면 D-Day가 변경됩니다. 오늘 날짜를 6월 12로 등록하였었는데 6월13일로 변경 하였을 때 d-day가 214에서 하루 줄어든 213을 볼 수 있습니다.|

<br>

|TOEIC 시험 일정버튼 클릭 – 날짜삭제|
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/32a16e76-5159-4fb0-9813-e584a5fbedd3)|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/2bc217bd-d24f-4ffc-ac28-12cee237e5df)|
|옆의 그리드뷰에서 시험날짜를 확인 후 시험일자를 입력한 뒤 날짜 삭제 버튼을 누르면 그 날의 시험 정보를 담은 데이터가 데이터베이스에서 삭제됩니다.|

<br>

|TOEIC 관련사이트 버튼 클릭 |
|------|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/23d1e16e-d1f8-4893-9d44-c00dee78bd7a)|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/e4e37030-ea71-4c41-b87e-87b385cc7cc6)|
|![image](https://github.com/yangjenniee/toeicmanagement/assets/92010971/db095fd9-957d-409a-8a38-9e09dc1fa6eb)|
|로고를 클릭하면 해당 사이트를 새 폼을 띄워 출력되게 하였습니다.|


