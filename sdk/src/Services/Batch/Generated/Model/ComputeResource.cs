/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object representing an AWS Batch compute resource.
    /// </summary>
    public partial class ComputeResource
    {
        private int? _bidPercentage;
        private int? _desiredvCpus;
        private string _ec2KeyPair;
        private string _imageId;
        private string _instanceRole;
        private List<string> _instanceTypes = new List<string>();
        private LaunchTemplateSpecification _launchTemplate;
        private int? _maxvCpus;
        private int? _minvCpus;
        private string _placementGroup;
        private List<string> _securityGroupIds = new List<string>();
        private string _spotIamFleetRole;
        private List<string> _subnets = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private CRType _type;

        /// <summary>
        /// Gets and sets the property BidPercentage. 
        /// <para>
        /// The maximum percentage that a Spot Instance price can be when compared with the On-Demand
        /// price for that instance type before instances are launched. For example, if your maximum
        /// percentage is 20%, then the Spot price must be below 20% of the current On-Demand
        /// price for that EC2 instance. You always pay the lowest (market) price and never more
        /// than your maximum percentage. If you leave this field empty, the default value is
        /// 100% of the On-Demand price.
        /// </para>
        /// </summary>
        public int BidPercentage
        {
            get { return this._bidPercentage.GetValueOrDefault(); }
            set { this._bidPercentage = value; }
        }

        // Check to see if BidPercentage property is set
        internal bool IsSetBidPercentage()
        {
            return this._bidPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredvCpus. 
        /// <para>
        /// The desired number of EC2 vCPUS in the compute environment. 
        /// </para>
        /// </summary>
        public int DesiredvCpus
        {
            get { return this._desiredvCpus.GetValueOrDefault(); }
            set { this._desiredvCpus = value; }
        }

        // Check to see if DesiredvCpus property is set
        internal bool IsSetDesiredvCpus()
        {
            return this._desiredvCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ec2KeyPair. 
        /// <para>
        /// The EC2 key pair that is used for instances launched in the compute environment.
        /// </para>
        /// </summary>
        public string Ec2KeyPair
        {
            get { return this._ec2KeyPair; }
            set { this._ec2KeyPair = value; }
        }

        // Check to see if Ec2KeyPair property is set
        internal bool IsSetEc2KeyPair()
        {
            return this._ec2KeyPair != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The Amazon Machine Image (AMI) ID used for instances launched in the compute environment.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRole. 
        /// <para>
        /// The Amazon ECS instance profile applied to Amazon EC2 instances in a compute environment.
        /// You can specify the short name or full Amazon Resource Name (ARN) of an instance profile.
        /// For example, <code>ecsInstanceRole</code> or <code>arn:aws:iam::&lt;aws_account_id&gt;:instance-profile/ecsInstanceRole</code>.
        /// For more information, see <a href="http://docs.aws.amazon.com/batch/latest/userguide/instance_IAM_role.html">Amazon
        /// ECS Instance Role</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceRole
        {
            get { return this._instanceRole; }
            set { this._instanceRole = value; }
        }

        // Check to see if InstanceRole property is set
        internal bool IsSetInstanceRole()
        {
            return this._instanceRole != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// The instances types that may be launched. You can specify instance families to launch
        /// any instance type within those families (for example, <code>c4</code> or <code>p3</code>),
        /// or you can specify specific sizes within a family (such as <code>c4.8xlarge</code>).
        /// You can also choose <code>optimal</code> to pick instance types (from the latest C,
        /// M, and R instance families) on the fly that match the demand of your job queues.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && this._instanceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template to use for your compute resources. Any other compute resource
        /// parameters that you specify in a <a>CreateComputeEnvironment</a> API operation override
        /// the same parameters in the launch template. You must specify either the launch template
        /// ID or launch template name in the request, but not both. 
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property MaxvCpus. 
        /// <para>
        /// The maximum number of EC2 vCPUs that an environment can reach. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int MaxvCpus
        {
            get { return this._maxvCpus.GetValueOrDefault(); }
            set { this._maxvCpus = value; }
        }

        // Check to see if MaxvCpus property is set
        internal bool IsSetMaxvCpus()
        {
            return this._maxvCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinvCpus. 
        /// <para>
        /// The minimum number of EC2 vCPUs that an environment should maintain (even if the compute
        /// environment is <code>DISABLED</code>). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int MinvCpus
        {
            get { return this._minvCpus.GetValueOrDefault(); }
            set { this._minvCpus = value; }
        }

        // Check to see if MinvCpus property is set
        internal bool IsSetMinvCpus()
        {
            return this._minvCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlacementGroup. 
        /// <para>
        /// The Amazon EC2 placement group to associate with your compute resources. If you intend
        /// to submit multi-node parallel jobs to your compute environment, you should consider
        /// creating a cluster placement group and associate it with your compute resources. This
        /// keeps your multi-node parallel job on a logical grouping of instances within a single
        /// Availability Zone with high network flow potential. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        public string PlacementGroup
        {
            get { return this._placementGroup; }
            set { this._placementGroup = value; }
        }

        // Check to see if PlacementGroup property is set
        internal bool IsSetPlacementGroup()
        {
            return this._placementGroup != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The EC2 security group that is associated with instances launched in the compute environment.
        /// 
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SpotIamFleetRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EC2 Spot Fleet IAM role applied to a
        /// <code>SPOT</code> compute environment.
        /// </para>
        /// </summary>
        public string SpotIamFleetRole
        {
            get { return this._spotIamFleetRole; }
            set { this._spotIamFleetRole = value; }
        }

        // Check to see if SpotIamFleetRole property is set
        internal bool IsSetSpotIamFleetRole()
        {
            return this._spotIamFleetRole != null;
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The VPC subnets into which the compute resources are launched. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && this._subnets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pair tags to be applied to resources that are launched in the compute environment.
        /// 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of compute environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CRType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}