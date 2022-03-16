using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the runningMedian function below.
     */
    static double[] runningMedian(int[] a) {
        /*
         * Write your code here.
         */
        double[] result = new double[a.Length];
        Heap maxHeap = new Heap(new List<int>(), true);
        Heap minHeap = new Heap(new List<int>(), false);
        for(int i = 0; i < a.Length; i++){
            if(maxHeap.arr.Count == 0){
                maxHeap.Add(a[i]);
            }
            else if(maxHeap.arr.Count == minHeap.arr.Count){
                if(a[i] < minHeap.Peek()){
                    maxHeap.Add(a[i]);
                }
                else{
                    minHeap.Add(a[i]);
                    maxHeap.Add(minHeap.ExtractTop());
                }
            }
            else if(maxHeap.arr.Count > minHeap.arr.Count){
                if(a[i] > maxHeap.Peek()){
                    minHeap.Add(a[i]);
                }
                else{
                    maxHeap.Add(a[i]);
                    minHeap.Add(maxHeap.ExtractTop());
                }
            }
            
            result[i] = Median(maxHeap, minHeap);
        }
        
        return result;
    }
    
    static double Median(Heap maxHeap, Heap minHeap){
        if(maxHeap.arr.Count == 0)
            return 0;
        else if(maxHeap.arr.Count == minHeap.arr.Count)
            return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
        else
            return maxHeap.Peek();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int aCount = Convert.ToInt32(Console.ReadLine());

        int[] a = new int [aCount];

        for (int aItr = 0; aItr < aCount; aItr++) {
            int aItem = Convert.ToInt32(Console.ReadLine());
            a[aItr] = aItem;
        }

        double[] result = runningMedian(a);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}

public class Heap{
    public List<int> arr { get; set; }
    public bool isMax { get; set; }
    public Heap(List<int> arr, bool isMax){
        this.arr = arr;
        this.isMax = isMax;
    }
    
    public void Add(int element){
        arr.Add(element);
        int i = arr.Count / 2;
        while(i > 0){
            Heapify(i);
            i = i / 2;
        }
        
        return;
    }
    
    public void Heapify(int index){
        var left = 2 * index;
        var right = 2 * index + 1;
        
        int root = index;
        if(left <= arr.Count && Compare(arr[left - 1], arr[index - 1], isMax)){
            root = left;
        }
        
        if(right <= arr.Count && Compare(arr[right - 1], arr[root - 1], isMax)){
            root = right;
        }
        
        if(root != index){
            int temp = arr[root - 1];
            arr[root - 1] = arr[index - 1];
            arr[index - 1] = temp;
            Heapify(root);
        }
        
        return;
    }
    
    public int ExtractTop(){
        int tmp = arr[0];    
        arr[0] = arr[arr.Count - 1];
        arr.RemoveAt(arr.Count - 1);
        Heapify(1);
        return tmp;
    }
    
    public int Peek(){
        return arr[0];
    }
    
    public bool Compare(int a, int b, bool isMax){
        if(isMax)
            return a > b;
        else 
            return a < b;
    }
}
