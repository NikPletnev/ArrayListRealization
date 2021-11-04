using System;

namespace Lists
{
    public class ArrayList
    {
        private int[] _arrayList;
        private int _listLength; //real list lenght other are independent null

        public ArrayList()
        {
            _listLength = 0;
            _arrayList = new int[10];
        }

        public ArrayList(int element)
        {
            _listLength = 1;
            _arrayList = new int[10];
            _arrayList[0] = element;
        }

        public ArrayList(int[] array)
        {
            _listLength = array.Length;
            _arrayList = new int[10];
            if (array.Length > 10)
            {
                ResizeArray(array.Length);
            }
            for (int i = 0; i < array.Length; i++)
            {
                _arrayList[i] = array[i];
            }
        }

        public int GetLenght()
        {
            return _listLength;
        }

        public int[] ToArray()
        {
            int[] returnArray = new int[_listLength];
            for (int i = 0; i < returnArray.Length; i++)
            {
                returnArray[i] = _arrayList[i];
            }
            return returnArray;
        }

        public void AddFirst(int val)
        {

            _listLength += 1;
            ResizeArray(_listLength);
            ShiftRight(1, 0);
            _arrayList[0] = val;
        }

        public void AddFirst(ArrayList list)
        {
            ResizeArray(_listLength + list.GetLenght());
            ShiftRight(list.GetLenght(), 0);
            _listLength += list.GetLenght();
            int[] addedList = list.ToArray();
            for (int i = 0; i < addedList.Length; i++)
            {
                _arrayList[i] = addedList[i];
            }

        }

        public void AddLast(int val)
        {
            _listLength += 1;
            int oldLenght = _arrayList.Length;
            ResizeArray(_arrayList.Length + 1);
            _arrayList[_listLength - 1] = val;

        }

        public void AddLast(ArrayList list)
        {
            int oldLenght = _listLength;
            _listLength += list.GetLenght();
            int[] addedList = list.ToArray();
            ResizeArray(_listLength);
            int countAddedListIndex = 0;
            for (int i = oldLenght; i < oldLenght + addedList.Length; i++)
            {
                _arrayList[i] = addedList[countAddedListIndex];
                countAddedListIndex++;
            }

        }

        public void AddAt(int idx, int val)
        {
            if (idx < 0 || idx > _listLength-1)
            {
                throw new ArgumentOutOfRangeException();
            }
            _listLength++;
            ResizeArray(_listLength);
            for (int i = _arrayList.Length - 1; i > idx; i--)
            {
                _arrayList[i] = _arrayList[i - 1];
            }
            _arrayList[idx] = val;
        }

        public void AddAt(int idx, ArrayList list)
        {
            if (idx < 0 || idx > _listLength - 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            ResizeArray(_listLength + list.GetLenght());
            ShiftRight(list.GetLenght(), idx);
            _listLength += list.GetLenght();
            int[] addedList = list.ToArray();
            for (int i = idx; i < idx + addedList.Length; i++)
            {
                _arrayList[i] = addedList[i - idx];
            }
        }

        public void Set(int idx, int val)
        {
            if (idx < 0 || idx > _listLength - 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            _arrayList[idx] = val;
        }

        public void RemoveFirst()
        {
            ShiftLeft(1, 1);
            _listLength--;
            SqueezeArray();
        }

        public void RemoveLast()
        {
            _listLength--;
            SqueezeArray();

        }

        public void RemoveAt(int idx)
        {
            if (idx < 0 || idx > _listLength - 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            ShiftLeft(1, idx+1);
            _listLength--;
            SqueezeArray();
           
        }


        public void RemoveFirstMultiple(int n)
        {
            for (int i = 0; i < _listLength - n; i++)
            {
                _arrayList[i] = _arrayList[i + n];
            }
            _listLength -= n;
            SqueezeArray();
        }

        public void RemoveLastMultiple(int n)
        {
            _listLength -= n;
            SqueezeArray();
        }

        public void RemoveAtMultiple(int idx, int n)
        {
            _listLength -= n;
            for (int i = idx; i < _arrayList.Length - n; i++)
            {
                _arrayList[i] = _arrayList[i + n];
            }
            SqueezeArray();
        }

        public void RemoveFirst(int val)
        {

            for (int i = 0; i < _listLength; i++)
            {
                if (_arrayList[i] == val)
                {
                    RemoveAt(i);
                    break;
                }
            }
            SqueezeArray();
        }

        public void RemoveAll(int val)
        {
            for (int i = 0; i < _listLength; i++)
            {

                if (_arrayList[i] == val)
                {
                    ShiftLeft(1, i + 1);
                    _listLength--;
                    i--;
                }
            }
            SqueezeArray();
        }

        public bool Contains(int val)
        {
            
           if(IndexOf(val) != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int IndexOf(int val)
        {
            for (int i = 0; i < _listLength; i++)
            {
                if (_arrayList[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }

        public int GetFirst()
        {
            return _arrayList[0];
        }

        public int GetLast()
        {
            return _arrayList[_listLength - 1];
        }

        public int Get(int idx)
        {
            if (idx < _listLength - 1)
            {
                return _arrayList[idx];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }

        public void Reverse()
        {
            
            int halfLength = _listLength / 2;
            for (int i = 0; i < halfLength; i++)
            {
                Swap(ref _arrayList[i], ref _arrayList[_listLength-i-1]);
            }
        } 

        public int Max()
        {
            int max = _arrayList[0];
            for (int i = 0; i < _listLength; i++)
            {
                if (max < _arrayList[i])
                {
                    max = _arrayList[i];
                }
            }
            return max;
        }


        public int Min()
        {
            int min = _arrayList[0];
            for (int i = 0; i < _listLength; i++)
            {
                if (min > _arrayList[i])
                {
                    min = _arrayList[i];
                }
            }
            return min;
        }

        public int IndexOfMax()
        {
            int max = _arrayList[0];
            int indexMax = 0;
            for (int i = 0; i < _listLength; i++)
            {
                if (max < _arrayList[i])
                {
                    max = _arrayList[i];
                    indexMax = i;
                }
            }
            return indexMax;
        }


        public int IndexOfMin()
        {
            int min = _arrayList[0];
            int indexMin = 0;
            for (int i = 0; i < _listLength; i++)
            {
                if (min > _arrayList[i])
                {
                    min = _arrayList[i];
                    indexMin = i;
                }
            }
            return indexMin;
        }

        public void Sort()
        {
            for (int index = 0; index < _listLength - 1; index++)
            {
                for (int indexSup = index + 1; indexSup < _listLength; indexSup++)
                {
                    if (_arrayList[index] > _arrayList[indexSup])
                    {
                        Swap(ref _arrayList[index], ref _arrayList[indexSup]);
                    }
                }
            }
        }

        public void SortDesc()
        {
            for (int index = 0; index < _listLength - 1; index++)
            {
                for (int indexSup = index + 1; indexSup < _listLength; indexSup++)
                {
                    if (_arrayList[index] < _arrayList[indexSup])
                    {
                        Swap(ref _arrayList[index], ref _arrayList[indexSup]);
                    }
                }
            }
        }

        private void ResizeArray(int newLenght)
        {
            if (newLenght <= _arrayList.Length)
            {
                return;
            }
            int currentLength = _arrayList.Length;
            while (currentLength < newLenght)
            {
                if (currentLength < 2)
                {
                    currentLength = 3;
                }
                else
                {
                    currentLength = currentLength * 3 / 2;
                }

            }
            int[] newArrayList = new int[currentLength];

            for (int i = 0; i < _arrayList.Length; i++)
            {
                newArrayList[i] = _arrayList[i];
            }
            _arrayList = newArrayList;

        }

        private void ShiftRight(int val, int idx)
        {
            for (int i = _listLength-1; i > idx-1; i--)
            {
                _arrayList[i + val] = _arrayList[i];
            }
        }

        private void ShiftLeft(int val, int idx)
        {
            for (int i = idx; i < _listLength; i++)
            {
                _arrayList[i - val] = _arrayList[i];
            }
        }

        private void SqueezeArray()
        {
            if (_listLength > 10)
            {
                int[] newArrayList = new int[_listLength];

                for (int i = 0; i < _listLength; i++)
                {
                    newArrayList[i] = _arrayList[i];
                }
                _arrayList = newArrayList;
            }
        }


        private void Swap(ref int numberA, ref int numberB)
        {
            int buffer = numberA;
            numberA = numberB;
            numberB = buffer;
        }


    }
}