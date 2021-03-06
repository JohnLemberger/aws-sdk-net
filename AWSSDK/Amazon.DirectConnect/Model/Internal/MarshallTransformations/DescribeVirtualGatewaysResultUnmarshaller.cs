/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */ 
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Amazon.DirectConnect.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// DescribeVirtualGatewaysResultUnmarshaller 
      /// </summary> 
      internal class DescribeVirtualGatewaysResultUnmarshaller : IUnmarshaller<DescribeVirtualGatewaysResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeVirtualGatewaysResult, JsonUnmarshallerContext> 
      { 
        DescribeVirtualGatewaysResult IUnmarshaller<DescribeVirtualGatewaysResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeVirtualGatewaysResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeVirtualGatewaysResult describeVirtualGatewaysResult = new DescribeVirtualGatewaysResult();
          describeVirtualGatewaysResult.VirtualGateways = null; 
                                  
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("VirtualGateways", targetDepth)) 
              {
                describeVirtualGatewaysResult.VirtualGateways = new List<VirtualGateway>();
                        VirtualGatewayUnmarshaller unmarshaller = VirtualGatewayUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeVirtualGatewaysResult.VirtualGateways.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return describeVirtualGatewaysResult; 
                } 
            } 
          
          
            return describeVirtualGatewaysResult; 
        } 
        
        private static DescribeVirtualGatewaysResultUnmarshaller instance; 
        public static DescribeVirtualGatewaysResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeVirtualGatewaysResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
