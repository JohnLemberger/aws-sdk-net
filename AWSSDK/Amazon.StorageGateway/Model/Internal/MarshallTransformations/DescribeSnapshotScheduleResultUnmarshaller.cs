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
    using Amazon.StorageGateway.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations 
    { 
      /// <summary> 
      /// DescribeSnapshotScheduleResultUnmarshaller 
      /// </summary> 
      internal class DescribeSnapshotScheduleResultUnmarshaller : IUnmarshaller<DescribeSnapshotScheduleResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeSnapshotScheduleResult, JsonUnmarshallerContext> 
      { 
        DescribeSnapshotScheduleResult IUnmarshaller<DescribeSnapshotScheduleResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }
        
        public DescribeSnapshotScheduleResult Unmarshall(JsonUnmarshallerContext context) 
        {
            DescribeSnapshotScheduleResult describeSnapshotScheduleResult = new DescribeSnapshotScheduleResult();
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
               
              if (context.TestExpression("VolumeARN", targetDepth)) 
              {
                describeSnapshotScheduleResult.VolumeARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("StartAt", targetDepth)) 
              {
                describeSnapshotScheduleResult.StartAt = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("RecurrenceInHours", targetDepth)) 
              {
                describeSnapshotScheduleResult.RecurrenceInHours = IntUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Description", targetDepth)) 
              {
                describeSnapshotScheduleResult.Description = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
              if (context.TestExpression("Timezone", targetDepth)) 
              {
                describeSnapshotScheduleResult.Timezone = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue; 
              }
   
                } 
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth) 
                { 
                    return describeSnapshotScheduleResult; 
                } 
            } 
          
          
            return describeSnapshotScheduleResult; 
        } 
        
        private static DescribeSnapshotScheduleResultUnmarshaller instance; 
        public static DescribeSnapshotScheduleResultUnmarshaller GetInstance() 
        { 
            if (instance == null) 
                instance = new DescribeSnapshotScheduleResultUnmarshaller(); 
            return instance;
        } 
    } 
} 
  
