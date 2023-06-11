### OOP_Project 상점관리 시스템

기존 프로젝트의 기능
---
### 기능
1. 재고 입고, 수정
2. 영수증 출력
3. 회원가입
4. 재고 확인
5. 판매 이력 관리

### 실행 화면
  + 로그인

![기존_로그인png](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/0016a413-2195-42cb-97c4-4da96575f4b7)
  + 대쉬보드
  
  1. 다른 여러 기능들로 이동 할 수 있는 툴바
  2. 상품과 고객 정보를 선택하여 영수증 출력

![기존_대쉬보드2](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/c68c3764-f7c2-496b-83ba-3d2da7ae8634)
  + 영수증

![기존_영수증](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/67a8933d-628a-4a43-ad0b-681966d2e311)
  + 회원가입

![기존_회원가입](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/0e122c0a-ac2d-49b5-888e-6e845123506b)
  + 재고 수정

![기존_재고수정](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/1c9e8316-d2f1-4d57-a118-02ad9c52a913)
  + 입고

![기존_입고](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/8429f23c-58d3-467b-a6fc-ed613b8e208d)
  + 판매 현황

![기존_판매현황](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/9ae1d712-4271-4b59-86b9-ac67f5aa4229)

##### 기존 프로젝트 출처
https://github.com/partha7278/GeneralStore#deshboard



업그레이드한 프로젝트 기능
-----
### 기능
- 상품 판매
  - 대쉬보드에서 상품 선택
  - 상품 판매(재고에서 빼고 판매 이력 생성)
  - 영수증 출력
- 재고 관리
  - 입고
  - 재고 수정
  - 상품별 판매 현황 검색
  - 상품별 판매 그래프
- 판매 이력 관리
  - 전체 판매 이력 조회
  - 날짜별 판매 이력 검색
  - 날짜별 판매 그래프
- 고객 관리
  - 고객 회원 가입
  - 고객 정보 수정
  - 단골 관리(할인률 적용)
  - 블랙리스트 관리
  - 고객별 판매 이력 검색
  - 고객별 판매 그래프
- 직원 관리
  - 직원 정보 조회
  - 신규 직원 등록
  - 직원 정보 수정
- 시스템 관리
  - 직원 정보로 로그인 

### 실행 화면 및 
  + 로그인
  
![로그인](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/c3bcea07-44ce-438e-8a02-8f516c99f10a)
```
제작자 혼자 가능했던 로그인을 직원들이 모두 각자의 아이디와 비밀번호로 로그인할 수 있도록 확장
직원을 새로 등록하는 신규 직원 등록 기능이 추가
```
  + 대쉬보드

![대쉬보드2](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/d9e7b6ef-e35f-4bbb-9e9a-dcc236f731d9)
```
재고의 변경이 없었던 기존과 다르게 물건 선택시 바로 재고에서 빠지고 취소시 재고가 추가되도록 수정
```
  + 영수증

![영수증](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/1e7baa84-1957-4456-80ed-711386cda6a9)
  + 전체 판매 기록 조회

![판매기록전체보기](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/e581b945-13a7-4ef1-bac8-d9a8ba49d0b3)
```
더욱 상세한 판매 내역을 한눈에 볼 수 있도록 수정
```
  + 고객별 판매 기록 조회

![고객별판매기록](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/0fa81c11-9a17-4d17-aa9c-680f7ebe9057)
```
각 고객이 어떤 상품을 구매 했는지 고객의 이름으로 검색할 수 있도록 추가
각 고객이 매출의 어느 정도를 차지하는지 한눈에 비교할 수 있도록 그래프를 추가
```
  + 제품별 판매 기록 조회

![제품별판매기록](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/43a8e954-4a3a-4345-ba62-715ea78d6040)
```
제품명을 통해 상품이 얼마나 판매 되었는지 검색 할 수 있도록 기능 추가
어떤 상품이 가장 수요가 좋은지 각각의 상품에 대해 한눈에 비교할 수 있도록 그래프 추가
```
  + 날짜별 매출 조회

![날짜별매출조회](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/01ed3dc7-90d4-46f0-9eec-915b0175475c)
```
해당 날짜의 판매 기록을 날짜 검색을 동해 조회 할 수 있도록 기능 추가
각 날짜별 매출을 한눈에 비교하기 위한 그래프 추가
```
  + 재고 정보 수정

![재고정보수정](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/b414535e-a69f-4771-b1ca-68fc8349f852)
  + 입고

![입고](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/c00d0105-0f75-4cb8-8b6b-4da40c1acad3)
```
기존에 있던 제품인지 아닌지 확인하고 없던 제품이면 새로 추가하고 있던 제품은 재고양만 증가시키도록 수정
```
  + 신규 고객 등록

![신규고객등록](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/cba874cd-cf89-41d7-8760-bbd80a96b220)
  + 고객 정보 수정

![고객정보수정](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/eef6daec-5d8b-49bd-aa8b-a93d0cca3daf)
```
고객에 대한 정보를 이름과 전화번호 외에는 수정할 수 있도록 추가
```
  + 블랙 리스트

![블랙리스트](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/a1647699-99df-467e-9bf2-74484b34c75e)
```
안전하고 효율적인 매장 운영을 위해 블랙리스트에 고객 정보를 등록할 수 있는 기능 추가
블랙리스트에 등록된 고객은 지속되는 것이 아니라 해제할 수 도 있도록 하는 기능 추가
```
  + 고객 할인률 관리

![할인률적용](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/8380f7dc-211a-4cdc-a5d3-d6f55b2ae591)
```
기존 할인률을 임의로 정하는 방식과는 다르게 고객 마다의 할인률을 미리 설정해 대쉬보드에서 고객 선택시 바로 할인이 적용 되로록 기능 확장
```
  + 직원 정보 조회

![직원정보조회](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/3151f74c-a968-400c-b0d4-a316bb12efd7)
```
직원들이 자신의 정보를 조회하거나 다른 직원에게 연락할 때 이용할 수 있도록 직원 정보 조회 기능 추가
급여 등의 사적인 정보는 제외되고 나머지 정보만 조회 가능
```
  + 직원 정보 등록

![직원정보등록](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/9a115e1d-0ac9-43ad-8806-cdf6ad266a7b)
```
직원이 이 프로그램을 사용하는 것으로 확장하면서 신규 직원 정보 등록 기능 추가
```
  + 직원 정보 수정

![직원정보수정](https://github.com/min-young417/store-management-system_OOP-Project/assets/122364547/5ded1808-329a-475f-bd15-72df059a5da3)
```
기존 비밀번호 변경 기능에서 전체적으로 다른 정보도 변경할 수 있도록 기능 추가
```
