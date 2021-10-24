using System;

namespace Lists
{
    public class ArrayList
    {
        private int[] _arrayList;
        private int _listLength; //real list lenght other are independent nulls

        public int[] List
        {
            get
            {
                return _arrayList;
            }
            private set
            {
                _arrayList = value;
            }
        }

        public ArrayList()
        {
            _listLength = 0;
            _arrayList = new int[0];
        }

        public ArrayList(int element)
        {
            _listLength = 1;
            _arrayList = new int[] { element };
        }

        public ArrayList(int[] array)
        {
            _listLength = array.Length;
            _arrayList = new int[array.Length];
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
            ResizeArray(_arrayList.Length + 1);
            _listLength += 1;
            for (int i = _arrayList.Length - 1; i > 0; i--)
            {
                _arrayList[i] = _arrayList[i - 1];
            }
            _arrayList[0] = val;
        }

        public void AddFirst(ArrayList list)
        {
            _listLength += list.GetLenght();
            int[] addedList = list.ToArray();
            ResizeArray(addedList.Length + _arrayList.Length);
            for (int i = _arrayList.Length - addedList.Length - 1; i > -1; i--)
            {
                _arrayList[i + addedList.Length] = _arrayList[i];
            }

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
            _listLength += list.GetLenght();
            int oldLenght = _arrayList.Length;
            int[] addedList = list.ToArray();
            ResizeArray(addedList.Length + _arrayList.Length);
            int countAddedListIndex = 0;
            for (int i = oldLenght; i < oldLenght + addedList.Length; i++)
            {
                _arrayList[i] = addedList[countAddedListIndex];
                countAddedListIndex++;
            }

        }

        public void AddAt(int idx, int val)
        {
            _listLength++;
            ResizeArray(_arrayList.Length + 1);
            for (int i = _arrayList.Length - 1; i > idx; i--)
            {
                _arrayList[i] = _arrayList[i - 1];
            }
            _arrayList[idx] = val;
        }

        public void AddAt(int idx, ArrayList list)
        {
            _listLength += list.GetLenght();
            int[] addedList = list.ToArray();
            ResizeArray(_arrayList.Length + addedList.Length);
            for (int i = _arrayList.Length - 1; i > idx + addedList.Length - 1; i--)
            {
                _arrayList[i] = _arrayList[i - addedList.Length];
            }
            for (int i = idx; i < idx + addedList.Length; i++)
            {
                _arrayList[i] = addedList[i - idx];
            }
        }

        public void Set(int idx, int val)
        {
            _arrayList[idx] = val;
        }

        public void RemoveFirst()
        {
            _listLength--;
            for (int i = 1; i < _arrayList.Length; i++)
            {
                _arrayList[i - 1] = _arrayList[i];
            }
            
        }

        public void RemoveLast()
        {
            _listLength--;
           
        }

        public void RemoveAt(int idx)
        {
            _listLength--;
            for (int i = idx; i < _arrayList.Length - 1; i++)
            {
                _arrayList[i] = _arrayList[i+1];
            }
        }


        public void RemoveFirstMultiple(int n)
        {
            for (int i = 0; i < _listLength - n; i++)
            {
                _arrayList[i] = _arrayList[i+n];
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
        }

        public void RemoveAll(int val)
        {
            for (int i = 0; i < _listLength; i++)
            {
                if (_arrayList[i] == val)
                {
                    RemoveAt(i);
                }
            }
        }

        public bool Contains(int val)
        {
            for (int i = 0; i < _listLength; i++)
            {
                if (_arrayList[i] == val)
                {
                    return true;
                }
            }
            return false;
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
           return _arrayList[1];
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
            }else
            {
                throw new IndexOutOfRangeException();
            }
            
        }

        public void Reverse()
        {
            int[] reversedArray = new int[_listLength];
            for (int i = 0; i < _listLength; i++)
            {
                reversedArray[i] = _arrayList[_listLength - i - 1]; ;
            }

            _arrayList = reversedArray;
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
            if(newLenght > _arrayList.Length)
            {
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

        }

        private void SqueezeArray()
        {
            int[] newArrayList = new int[_listLength];

            for (int i = 0; i < _listLength; i++)
            {
                newArrayList[i] = _arrayList[i];
            }
            _arrayList = newArrayList;
        }

         
        private void Swap(ref int numberA, ref int numberB)
        {
            int buffer = numberA;
            numberA = numberB;
            numberB = buffer;
        }


    }
}