# [영화] Unity로 만든 단편 애니메이션 <Human Recipe>


</br>

## :memo: 목차

- [프로젝트 개요](#프로젝트-개요)
- [핵심 기술 구현](#핵심-기술-구현)
- [영상](#영상)
- [회고록](#회고록)
- [참고자료](#참고자료)

</br>

# 프로젝트 개요

|제목|Unity로 만든 단편 애니메이션 <Human Recipe>|
|:------:|---|
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
- 원하는 부분만 볼 수 있도록 UI 토글을 활용하여 모델링별 활성화 제어 기능
- Reset / Delete /Phase(공정) 버튼과 토글 활성화 기능이 상호작용하도록 설계하여 원클릭 전체 제어 기능
- Phase 버튼을 키면 슬라이더를 활용하여 공정 단계별(1~4단계) 이미지 확인 가능

### :ballot_box_with_check: Rokoko를 활용한 모션 캡쳐 촬영 및 애니메이션 적용
- 버튼과 토글, 슬라이더 스크립트에서 함께 공유하는 게임 오브젝트와 UI 오브젝트를 싱글톤으로 만든 ResourceManager에서 관리하여 중복 코드를 줄이고 유지 보수의 용이성을 높임.

</br>

# 시연 영상

- 영상 링크: https://www.youtube.com/watch?v=JlwMx1OHJJU&feature=youtu.be

</br>

# 회고록

