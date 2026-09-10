# Assignment 05: การเรียนรู้ Sorting Algorithms สำหรับ Game Development

## 🎯 จุดประสงค์การเรียนรู้

- เรียนรู้การใช้งาน Sorting Algorithms พื้นฐาน (Selection Sort, Bubble Sort, Insertion Sort)
- เข้าใจการจัดเรียงข้อมูลแบบ ascending (น้อยไปมาก) และ descending (มากไปน้อย)
- นำ Sorting Algorithms มาใช้ในการแก้ปัญหาในเกม เช่น การจัดอันดับคะแนน หาค่าสูงสุด-ต่ำสุด
- วิเคราะห์ลำดับของข้อมูลต่อเนื่องกัน (consecutive sequence)
- เขียน code ที่มีประสิทธิภาพในการจัดการข้อมูลแบบเรียงลำดับ

## 📚 โครงสร้างของ Assignment

- **Lecture Methods (3 methods)** - การ implement ฝึกหัด Sorting Algorithms พื้นฐาน พร้อมกันในห้องเรียน
- **Assignment Methods (4 methods)** - การประยุกต์ใช้ Sorting Algorithms ในสถานการณ์เกม
- **Extra Methods (1 method)** - การแก้ปัญหาขั้นสูงที่เกี่ยวข้องกับลำดับข้อมูล

---

## 🧠 ความรู้พื้นฐานที่ควรทราบ

### Sorting Algorithms คืออะไร?
Sorting Algorithm คือขั้นตอนการจัดเรียงข้อมูลให้อยู่ในลำดับที่ต้องการ เช่น จากน้อยไปมาก (ascending) หรือจากมากไปน้อย (descending)

### ในเกมใช้ Sorting ทำอะไรบ้าง?
- **จัดอันดับคะแนน**: เรียงผู้เล่นตามคะแนนสูงสุด
- **จัดเรียงไอเท็ม**: เรียงไอเท็มตามราคา หรือความแรง
- **หาค่าสูงสุด/ต่ำสุด**: หา damage สูงสุด หรือ HP ต่ำสุด
- **จัดเรียงข้อมูลการแข่งขัน**: เรียงเวลาที่ดีที่สุด
- **วิเคราะห์ลำดับ**: หาชุดข้อมูลที่ต่อเนื่องกัน เช่น combo หรือ streak

---

## Lecture Methods

The sorting methods return a new sorted array and do not modify the input array.

Methods เหล่านี้แสดงแนวคิด Sorting Algorithms พื้นฐาน Implement เพื่อฝึกหัดแต่จะไม่มีการให้คะแนน

### 1. LCT01_SelectionSortAscending

**วัตถุประสงค์:** เรียนรู้การทำงานของ Selection Sort สำหรับการเรียงลำดับจากน้อยไปมาก

**หลักการทำงานของ Selection Sort:**
1. หาค่าที่เล็กที่สุดใน array
2. สลับค่านั้นมาไว้ตำแหน่งแรก
3. หาค่าที่เล็กที่สุดในส่วนที่เหลือ
4. สลับมาไว้ตำแหน่งที่สอง
5. ทำซ้ำจนครบทุกตำแหน่ง

**Method Signature:**
```csharp
int[] LCT01_SelectionSortAscending(int[] numbers)
```

**Logic ที่ต้อง implement:**
- ใช้ nested loop: outer loop เดินไปทุกตำแหน่ง, inner loop หาค่าน้อยสุด
- สลับค่าน้อยสุดมาไว้ตำแหน่งปัจจุบัน
- แสดงผลลัพธ์ที่เรียงแล้วทีละบรรทัด

**Test Cases:**
1. **Input:** `[5, 2, 8, 1, 9]`
   **Expected Output:**
   ```
   1
   2
   5
   8
   9
   ```

2. **Input:** `[1, 2, 3, 4, 5]` (เรียงแล้ว)
   **Expected Output:**
   ```
   1
   2
   3
   4
   5
   ```

3. **Input:** `[5, 4, 3, 2, 1]` (เรียงย้อนกลับ)
   **Expected Output:**
   ```
   1
   2
   3
   4
   5
   ```

4. **Input:** `[42]` (ตัวเลขเดียว)
   **Expected Output:**
   ```
   42
   ```

### 2. LCT02_BubbleSortAscending

**วัตถุประสงค์:** เรียนรู้การทำงานของ Bubble Sort สำหรับการเรียงลำดับจากน้อยไปมาก

**หลักการทำงานของ Bubble Sort:**
1. เปรียบเทียบคู่ข้างเคียงทีละคู่
2. ถ้าตัวซ้ายมากกว่าตัวขวา ให้สลับที่กัน
3. ทำไปเรื่อยๆ จนค่าใหญ่สุด "ลอยขึ้น" ไปด้านขวา
4. ทำซ้ำจนทุกค่าอยู่ในตำแหน่งที่ถูกต้อง

**Method Signature:**
```csharp
int[] LCT02_BubbleSortAscending(int[] numbers)
```

**Logic ที่ต้อง implement:**
- ใช้ nested loop: outer loop ควบคุมรอบ, inner loop เปรียบเทียบคู่ข้างเคียง
- สลับค่าถ้าตัวซ้ายมากกว่าตัวขวา
- แสดงผลลัพธ์ที่เรียงแล้วทีละบรรทัด

**Test Cases:**
1. **Input:** `[64, 34, 25, 12, 22, 11, 90]`
   **Expected Output:**
   ```
   11
   12
   22
   25
   34
   64
   90
   ```

2. **Input:** `[3, 1, 3, 2, 1]` (มีค่าซ้ำ)
   **Expected Output:**
   ```
   1
   1
   2
   3
   3
   ```

### 3. LCT03_InsertionSortAscending

**วัตถุประสงค์:** เรียนรู้การทำงานของ Insertion Sort สำหรับการเรียงลำดับจากน้อยไปมาก

**หลักการทำงานของ Insertion Sort:**
1. เริ่มจากตำแหน่งที่ 2 (index 1)
2. เอาค่าปัจจุบันไป "แทรก" ในส่วนที่เรียงแล้ว
3. เลื่อนค่าที่มากกว่าไปด้านขวา
4. วางค่าปัจจุบันในตำแหน่งที่เหมาะสม
5. ทำซ้ำจนครบทุกตำแหน่ง

**Method Signature:**
```csharp
int[] LCT03_InsertionSortAscending(int[] numbers)
```

**Logic ที่ต้อง implement:**
- ใช้ loop เริ่มจาก index 1
- สำหรับแต่ละตำแหน่ง ให้ "แทรก" ค่านั้นในส่วนที่เรียงแล้ว
- ใช้ while loop เลื่อนค่าที่มากกว่าไปด้านขวา
- แสดงผลลัพธ์ที่เรียงแล้วทีละบรรทัด

**Test Cases:**
1. **Input:** `[12, 11, 13, 5, 6]`
   **Expected Output:**
   ```
   5
   6
   11
   12
   13
   ```

2. **Input:** `[-5, 2, -3, 8, 0]` (มีเลขติดลบ)
   **Expected Output:**
   ```
   -5
   -3
   0
   2
   8
   ```

---

## Assignment Methods

Methods เหล่านี้เป็นการประยุกต์ใช้ Sorting Algorithms ในสถานการณ์เกม และจะมีการให้คะแนน

### AS01_SelectionSortDescending

**วัตถุประสงค์:** ใช้ Selection Sort เรียงลำดับจากมากไปน้อย (เหมือนจัดอันดับคะแนนในเกม)

**ตัวอย่างการใช้งานในเกม:** จัดอันดับคะแนนสูงสุดของผู้เล่น หรือเรียงพลังโจมตีของอาวุธจากแรงสุดไปอ่อนสุด

**Method Signature:**
```csharp
int[] AS01_SelectionSortDescending(int[] numbers)
```

**Logic ที่ต้อง implement:**
- คล้าย Selection Sort แต่หาค่า**มากสุด**แทนค่าน้อยสุด
- สลับค่ามากสุดมาไว้ตำแหน่งแรก แล้วหาค่ามากสุดถัดไป
- แสดงผลลัพธ์ที่เรียงแล้วทีละบรรทัด

**Test Cases:**
1. **Input:** `[5, 2, 8, 1, 9]`
   **Expected Output:**
   ```
   9
   8
   5
   2
   1
   ```

2. **Input:** `[7, 3, 7, 1, 3]` (มีค่าซ้ำ)
   **Expected Output:**
   ```
   7
   7
   3
   3
   1
   ```

### AS02_BubbleSortDescending

**วัตถุประสงค์:** ใช้ Bubble Sort เรียงลำดับจากมากไปน้อย

**ตัวอย่างการใช้งานในเกม:** เรียงราคาไอเท็มจากแพงสุดไปถูกสุด หรือเรียง HP ของมอนสเตอร์จากมากสุดไปน้อยสุด

**Method Signature:**
```csharp
int[] AS02_BubbleSortDescending(int[] numbers)
```

**Logic ที่ต้อง implement:**
- คล้าย Bubble Sort แต่เปลี่ยนเงื่อนไขการเปรียบเทียบ
- สลับถ้าตัวซ้าย**น้อยกว่า**ตัวขวา (เพื่อให้ค่าใหญ่ไปด้านซ้าย)
- แสดงผลลัพธ์ที่เรียงแล้วทีละบรรทัด

**Test Cases:**
1. **Input:** `[64, 34, 25, 12, 22, 11, 90]`
   **Expected Output:**
   ```
   90
   64
   34
   25
   22
   12
   11
   ```

2. **Input:** `[9, 7, 5, 3, 1]` (เรียงจากมากไปน้อยแล้ว)
   **Expected Output:**
   ```
   9
   7
   5
   3
   1
   ```

### AS03_InsertionSortDescending

**วัตถุประสงค์:** ใช้ Insertion Sort เรียงลำดับจากมากไปน้อย

**ตัวอย่างการใช้งานในเกม:** เรียงระดับความยากของด่าน หรือเรียงเวลาการแข่งขันจากเร็วสุดไปช้าสุด

**Method Signature:**
```csharp
int[] AS03_InsertionSortDescending(int[] numbers)
```

**Logic ที่ต้อง implement:**
- คล้าย Insertion Sort แต่เปลี่ยนเงื่อนไขการเปรียบเทียบ
- แทรกค่าในตำแหน่งที่เหมาะสมเพื่อให้เรียงจากมากไปน้อย
- แสดงผลลัพธ์ที่เรียงแล้วทีละบรรทัด

**Test Cases:**
1. **Input:** `[12, 11, 13, 5, 6]`
   **Expected Output:**
   ```
   13
   12
   11
   6
   5
   ```

2. **Input:** `[-5, 2, -3, 8, 0]` (มีเลขติดลบ)
   **Expected Output:**
   ```
   8
   2
   0
   -3
   -5
   ```

### AS04_FindTheSecondLargestNumber

This method returns the second-largest distinct number as an `int`.

**วัตถุประสงค์:** หาตัวเลขที่มีค่ามากเป็นอันดับสองใน array

**ตัวอย่างการใช้งานในเกม:** หาผู้เล่นที่ได้คะแนนสูงเป็นอันดับ 2, หาอาวุธที่แรงเป็นอันดับ 2, หา HP สูงสุดอันดับ 2

**Method Signature:**
```csharp
int AS04_FindTheSecondLargestNumber(int[] numbers)
```

**Logic ที่ต้อง implement:**
- เรียง array จากมากไปน้อย (สามาารถใช้ Array.Sort และ Array.Reverse ได้ เพื่อความง่าย หรือจะ implement sorting เองก็ได้)
- หาค่าแรกที่น้อยกว่าค่าสูงสุด (เพื่อข้าม duplicates)
- แสดงผลค่าที่มากเป็นอันดับสอง

**Test Cases:**
1. **Input:** `[1, 2, 3, 4, 5]`
   **Expected Output:** `4`

2. **Input:** `[5, 5, 4, 3, 2]` (มีค่าสูงสุดซ้ำ)
   **Expected Output:** `4`

3. **Input:** `[3, 7, 1, 9, 5]` (ไม่เรียงลำดับ)
   **Expected Output:** `7`

4. **Input:** `[-1, -5, 3, 0, 2]` (มีเลขติดลบ)
   **Expected Output:** `2`

5. **Input:** `[10, 5]` (สองตัวเลข)
   **Expected Output:** `5`

---

## Extra Methods

### EX01_FindLongestConsecutiveSequence

This method returns the length of the longest consecutive sequence as an `int`.

**วัตถุประสงค์:** หาความยาวของชุดตัวเลขที่เรียงลำดับติดต่อกันที่ยาวที่สุด

**ตัวอย่างการใช้งานในเกม:** 
- หา combo streak ที่ยาวที่สุด
- หาระดับที่ผู้เล่นเล่นต่อเนื่องกันมากที่สุด

**ตัวอย่าง:** 
- Input: `[1, 9, 3, 10, 4, 20, 2]`
- เมื่อเรียงแล้ว: `[1, 2, 3, 4, 9, 10, 20]`
- ชุดต่อเนื่อง: `[1,2,3,4]` (ความยาว 4), `[9,10]` (ความยาว 2), `[20]` (ความยาว 1)
- ผลลัพธ์: 4 (ความยาวที่มากที่สุด)

**Method Signature:**
```csharp
int EX01_FindLongestConsecutiveSequence(int[] numbers)
```

**Logic ที่ต้อง implement:**
- เรียง array จากน้อยไปมาก
- วนลูปเปรียบเทียบแต่ละคู่ข้างเคียง
- ถ้าต่างกัน 1 ให้เพิ่ม current streak
- ถ้าไม่ต่อเนื่อง ให้รีเซ็ต current streak
- เก็บ streak ที่ยาวที่สุด
- แสดงผลในรูปแบบ "The longest consecutive sequence is: {length}"

**Test Cases:**
1. **Input:** `[1, 9, 3, 10, 4, 20, 2]`
   **Expected Output:** `The longest consecutive sequence is: 4`

2. **Input:** `[5, 4, 3, 2, 1]` (ทุกตัวต่อเนื่อง)
   **Expected Output:** `The longest consecutive sequence is: 5`

3. **Input:** `[1, 3, 5, 7, 9]` (ไม่มีตัวต่อเนื่อง)
   **Expected Output:** `The longest consecutive sequence is: 1`

4. **Input:** `[1, 2, 2, 3, 4]` (มีค่าซ้ำ)
   **Expected Output:** `The longest consecutive sequence is: 4`

5. **Input:** `[42]` (ตัวเลขเดียว)
   **Expected Output:** `The longest consecutive sequence is: 1`

6. **Input:** `[100, 4, 200, 1, 3, 2, 101, 102]` (หลายชุดต่อเนื่อง)
   **Expected Output:** `The longest consecutive sequence is: 4`

7. **Input:** `[-2, -1, 0, 1, 2, 5]` (มีเลขติดลบ)
   **Expected Output:** `The longest consecutive sequence is: 5`

---

## 💡 เทคนิคการเขียนโปรแกรม

### 1. การเปรียบเทียบ Sorting Algorithms

| Algorithm | ความเร็ว | ความง่าย | Big-O |
|-----------|---------|----------|-------|
| Selection Sort | ช้า | ง่าย | O(n^2) |
| Bubble Sort | ช้าสุด | ง่ายสุด | O(n^2) |
| Insertion Sort | ปานกลาง | ปานกลาง | O(n^2) |

### 2. การเลือกใช้ใน Game Development

- **High Score Leaderboard**: ใช้ built-in sorting (Array.Sort) เพื่อความเร็ว
- **Real-time Sorting**: ใช้ Insertion Sort ถ้าข้อมูลเกือบเรียงแล้ว

### 3. การจัดการ Edge Cases

- **Array ว่าง**: ตรวจสอบ `numbers.Length == 0`
- **ตัวเลขเดียว**: ตรวจสอบ `numbers.Length == 1`
- **ค่าซ้ำ**: ตรวจสอบและจัดการอย่างถูกต้อง
- **เลขติดลบ**: ใช้การเปรียบเทียบเดียวกัน

---

## 🚀 การประยุกต์ใช้ในเกม

### 1. RPG Game
- เรียงไอเท็มตามราคา/ความแรง
- จัดอันดับผู้เล่นตามระดับ
- หาอาวุธที่เหมาะสมสำหรับผู้เล่น

### 2. Racing Game
- เรียงเวลาการแข่งขันจากเร็วสุด
- หาผู้เล่นที่มาเป็นอันดับ 2
- วิเคราะห์ลำดับการแซง

### 3. Puzzle Game
- เรียงคะแนนจากสูงสุด
- หา combo ที่ยาวที่สุด
- จัดเรียงระดับความยาก

### 4. Strategy Game
- เรียงกองทัพตามความแรง
- หายูนิตที่แรงเป็นอันดับ 2
- วิเคราะห์ลำดับการอัปเกรด
