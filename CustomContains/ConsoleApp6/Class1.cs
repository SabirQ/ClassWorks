using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    static class Class1
    {
        public static bool Cn(this string a, string w)
        {
            bool result = false;
            StringBuilder st = new StringBuilder();
            int j = 0;
            int count = 0;
            for (int i = 0; i < a.Length;i++ )
            {
                
                if (w[j] == a[i])
                {
                    st.Append(a[i]);
                    j++;
                   
                    count++;
                  
                    if (st.ToString().ToLower()==w.ToLower())
                    {
                        result = true;
                        break;
                    }                                            
                                           
                }
                else
                {
                    if (j!=0)
                    {
                        count++;
                        count -= st.Length;
                        
                        i = i - count;
                        st.Clear();
                        j = 0;
                    }
                    else
                    {
                        
                    }
                    
                    


                   
                }
                
                

                
            }



            return result;
        }
    }
}
