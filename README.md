# [영화] Unity로 만든 단편 애니메이션 <Human Recipe>


</br>

## :memo: 목차

- [프로젝트 개요](#프로젝트-개요)
- [핵심 기술 구현](#핵심-기술-구현)
- [영상](#영상)
- [회고록](#회고록)

</br>

# 프로젝트 개요

|제목|Unity로 만든 단편 애니메이션 [Human Recipe]|
|:------:|:---|
|장르 | 드라마, 미스테리|
|제작기간 | 3주|
|제작도구 |Unity (2022.3.2f1), Rokoko, Sketchup|
|사용언어 |C#|
|팀원 | 11명|
|기획의도| - Unity 촬영, 편집, 조명 등을 활용한 영상 제작 경험 <br> - Rokoko를 활용하여 모션캡쳐 제작 및 Unity 내 애니메이션 활용 <br> - 인간과 AI노아의 대화를 통해 기하급수적인 발전을 이루고 있는 AI와는 다른 '인간다움'의 의미에 대한 고찰

</br>

# 핵심 기술 구현

### :ballot_box_with_check: Unity Cinemachine을 활용한 Unity 촬영
- Cinemachine 플러그인의 Virtual Camera를 활용하여 자유로운 카메라 무빙 구현
- Dolly Camera with track을 활용하여 안정적인 카메라 무빙 구현

### :ballot_box_with_check: Unity Timeline을 활용한 영상 편집
- 프레임별 각 캐릭터의 animation 관리
- Cut별 카메라 설치 및 카메라 무빙 구현 (Animation 활용)
- Activation 기능을 활용하여 Cut별 조명 및 오브젝트 활성화 관리

### :ballot_box_with_check: Rokoko를 활용한 모션 캡쳐 촬영 및 애니메이션 적용
- Rokoko 디바이스 연결 및 Calibration
- 모션캡쳐 디렉팅
- 모션캡쳐 파일 백업 및 애니메이터 분담 공유
- 모션캡쳐 애니메이션 수정 완료본 확인 및 공

</br>

# 영상

- 영상 링크: [https://www.youtube.com/watch?v=JlwMx1OHJJU&feature=youtu.be](https://www.youtube.com/watch?v=QmhNyU5JEQQ)https://www.youtube.com/watch?v=QmhNyU5JEQQ

</br>

# 회고록

### :ballot_box_with_check: 얼굴 Mesh 애니메이션 오류 발생
- 캐릭터에 모션캡쳐본 애니메이션을 적용했을 때, Body는 맵핑이 잘되었으나 Facial 모션캡쳐 데이터는 맵핑되지 않음.
  ㄴ 3D 캐릭터의 얼굴에 리깅과 메쉬가 있음에도 불구하고 적용되지 않음.

#### :bulb: 문제원인
: 모션캡쳐본 파일의 얼굴 관련 Object의 이름이 'Newton_HeadFace'로 되어 있는데, 현재 하이어라키창에 있는 캐릭터의 얼굴 관련 Object의 이름은 'Head_10'으로 되어 있어 맵핑이 불가능하였다.
#### :bulb: 해결방안 
: Animation창에 나열된 Object의 '이름'과 하이어라키에 있는 object의 '이름'을 일치시킨다!
* 구체적인 해결 과정: https://drive.google.com/file/d/1WaQEmYCNAytadC0gcquZzMndKYzWWyCI/view?usp=sharing
