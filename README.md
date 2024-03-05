# SpartaDungeon2D
Unity 2D 게임 팀 프로젝트

## 프로젝트 소개
던전에서 몬스터를 잡고 아이템을 파밍해서 던전마지막층을 공략하는것이 목표

## 멤버 구성
팀장 이인규:    
팀원 김준서:    
팀원 석동구: 플레이어 구현, 플레이어 공격 구현, 몬스터 랜덤 스폰 구현   
팀원 이서현: 아이템(스피드, 체력 회복) 구현, 아이템 랜덤 생성 구현, 인벤토리 구현

## 주요 기능
1. 플레이어 이동 및 공격 구현
2. 몬스터 이동 및 공격 구현
3. 플레이어 및 몬스터 피격 구현
4. 아이템 및 인벤토리 구현
5. 게임 UI구현

## 트러블 슈팅
팀장 이인규:   
팀원 김준서:   
팀원 석동구:   
[문제]   
몬스터가 플레이어을 때려도 아무런 반응이없음   
[원인]   
몬스터에 IsTrigger가 켜져있었다.   
[해결]   
몬스터 Collider2D에 있는  IsTrigger 끄니 정상적으로 작동하였다.  

팀원 이서현:   
[문제]   
처음 주운 아이템을 사용하면  nullReference 오류 발생   
[원인]   
아이템 오브젝트를 findObjectOfType으로 찾아서 아이템을 사용할 수 있게 함   
findObjectOfType은 씬에 존재하지 않으면 null인 오류가 발생하게 됨   
플레이어가 아이템을 줍는 순간 아이템의 오브젝트가 사라지게 되므로 nullReference와 같은 문제가 발생   
[해결]   
아이템들의 데이터를 Scriptable Object로 저장   
ItemDataManager에서 아이템 데이터들을 관리   
슬롯에 ItemDataManager에 있는 아이템 정보들을 가져와서 사용할 수 있게 함   

## 개발 기간
24.02.26(월) ~ 24.03.04(월)

## 유니티 버전
Unity Editor Version 2022.3.2f1   
IDE: Visual Studio 2022

## 게임 플레이
---
#### 시작화면
<img src = "https://github.com/Rivene/SpartaDungeon2D/assets/129824716/b75fcac7-3919-44d6-8092-513d29c3847a" width="400" height="300"/>

---
#### 메인 던전 화면
<img src = "https://github.com/Rivene/SpartaDungeon2D/assets/129824716/a9227ccb-22ad-41a1-81dc-00eabf1674ce" width="400" height="300"/>

---
#### 게임 클리어 화면
<img src = "https://github.com/Rivene/SpartaDungeon2D/assets/129824716/9b86408f-d6ba-4018-b551-d462251bb670" width="400" height="300"/>

---
#### 게임 오버 화면
<img src = "https://github.com/Rivene/SpartaDungeon2D/assets/129824716/57ff1015-13ca-4598-9bff-5779aad5c20a" width="400" height="300"/>
