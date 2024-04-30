
/*!
<auto-generated>
    This code was generated by a tool.
    Changes to this file may cause incorrect behavior and will be lost if
    the code is regenerated.
</auto-generated>
*/


use super::*;
use serde::Deserialize;

#[derive(Deserialize, Debug, Hash, Eq, PartialEq)]
pub enum EKeyType {
    BOOL = 1,
    INT = 2,
    FLOAT = 3,
    STRING = 4,
    VECTOR = 5,
    ROTATOR = 6,
    NAME = 7,
    CLASS1 = 8,
    ENUM1 = 9,
    OBJECT = 10,
}

impl From<i32> for EKeyType {
    fn from(value: i32) -> Self {
        match value { 
            1 => EKeyType::BOOL,
            2 => EKeyType::INT,
            3 => EKeyType::FLOAT,
            4 => EKeyType::STRING,
            5 => EKeyType::VECTOR,
            6 => EKeyType::ROTATOR,
            7 => EKeyType::NAME,
            8 => EKeyType::CLASS1,
            9 => EKeyType::ENUM1,
            10 => EKeyType::OBJECT,
            _ => panic!("Invalid value for EKeyType:{}", value),
        }
    }
}

#[derive(Deserialize, Debug, Hash, Eq, PartialEq)]
pub enum EFlowAbortMode {
    NONE = 0,
    LOWER_PRIORITY = 1,
    SELF = 2,
    BOTH = 3,
}

impl From<i32> for EFlowAbortMode {
    fn from(value: i32) -> Self {
        match value { 
            0 => EFlowAbortMode::NONE,
            1 => EFlowAbortMode::LOWER_PRIORITY,
            2 => EFlowAbortMode::SELF,
            3 => EFlowAbortMode::BOTH,
            _ => panic!("Invalid value for EFlowAbortMode:{}", value),
        }
    }
}

#[derive(Deserialize, Debug, Hash, Eq, PartialEq)]
pub enum ENotifyObserverMode {
    ON_VALUE_CHANGE = 0,
    ON_RESULT_CHANGE = 1,
}

impl From<i32> for ENotifyObserverMode {
    fn from(value: i32) -> Self {
        match value { 
            0 => ENotifyObserverMode::ON_VALUE_CHANGE,
            1 => ENotifyObserverMode::ON_RESULT_CHANGE,
            _ => panic!("Invalid value for ENotifyObserverMode:{}", value),
        }
    }
}

#[derive(Deserialize, Debug, Hash, Eq, PartialEq)]
pub enum EOperator {
    IS_EQUAL_TO = 0,
    IS_NOT_EQUAL_TO = 1,
    IS_LESS_THAN = 2,
    IS_LESS_THAN_OR_EQUAL_TO = 3,
    IS_GREAT_THAN = 4,
    IS_GREAT_THAN_OR_EQUAL_TO = 5,
    CONTAINS = 6,
    NOT_CONTAINS = 7,
}

impl From<i32> for EOperator {
    fn from(value: i32) -> Self {
        match value { 
            0 => EOperator::IS_EQUAL_TO,
            1 => EOperator::IS_NOT_EQUAL_TO,
            2 => EOperator::IS_LESS_THAN,
            3 => EOperator::IS_LESS_THAN_OR_EQUAL_TO,
            4 => EOperator::IS_GREAT_THAN,
            5 => EOperator::IS_GREAT_THAN_OR_EQUAL_TO,
            6 => EOperator::CONTAINS,
            7 => EOperator::NOT_CONTAINS,
            _ => panic!("Invalid value for EOperator:{}", value),
        }
    }
}

#[derive(Deserialize, Debug, Hash, Eq, PartialEq)]
pub enum EFinishMode {
    IMMEDIATE = 0,
    DELAYED = 1,
}

impl From<i32> for EFinishMode {
    fn from(value: i32) -> Self {
        match value { 
            0 => EFinishMode::IMMEDIATE,
            1 => EFinishMode::DELAYED,
            _ => panic!("Invalid value for EFinishMode:{}", value),
        }
    }
}

#[derive(Deserialize, Debug)]
pub struct Blackboard {
    pub name: String,
    pub desc: String,
    pub parent_name: String,
    pub keys: Vec<crate::ai::BlackboardKey>,
}

impl Blackboard{
    pub fn new(json: &serde_json::Value) -> Blackboard {
        let name = json["name"].as_str().unwrap().to_string();
        let desc = json["desc"].as_str().unwrap().to_string();
        let parent_name = json["parent_name"].as_str().unwrap().to_string();
        let keys = json["keys"].as_array().unwrap().iter().map(|field| crate::ai::BlackboardKey::new(&field)).collect();
        
        Blackboard { name, desc, parent_name, keys, }
    }
}

#[derive(Deserialize, Debug)]
pub struct BlackboardKey {
    pub name: String,
    pub desc: String,
    pub is_static: bool,
    pub key_type: crate::ai::EKeyType,
    pub type_class_name: String,
}

impl BlackboardKey{
    pub fn new(json: &serde_json::Value) -> BlackboardKey {
        let name = json["name"].as_str().unwrap().to_string();
        let desc = json["desc"].as_str().unwrap().to_string();
        let is_static = json["is_static"].as_bool().unwrap();
        let key_type = <i32 as std::str::FromStr>::from_str(&json["key_type"].to_string()).unwrap().into();
        let type_class_name = json["type_class_name"].as_str().unwrap().to_string();
        
        BlackboardKey { name, desc, is_static, key_type, type_class_name, }
    }
}

#[derive(Deserialize, Debug)]
pub struct BehaviorTree {
    pub id: i32,
    pub name: String,
    pub desc: String,
    pub blackboard_id: String,
    pub root: crate::ai::ComposeNode,
}

impl BehaviorTree{
    pub fn new(json: &serde_json::Value) -> BehaviorTree {
        let id = json["id"].as_i64().unwrap() as i32;
        let name = json["name"].as_str().unwrap().to_string();
        let desc = json["desc"].as_str().unwrap().to_string();
        let blackboard_id = json["blackboard_id"].as_str().unwrap().to_string();
        let root = crate::ai::ComposeNode::new(&json["root"]);
        
        BehaviorTree { id, name, desc, blackboard_id, root, }
    }
}

#[derive(Deserialize, Debug)]
pub struct Node {
    pub id: i32,
    pub node_name: String,
}

impl Node{
    pub fn new(json: &serde_json::Value) -> Node {
        let id = json["id"].as_i64().unwrap() as i32;
        let node_name = json["node_name"].as_str().unwrap().to_string();
        
        Node { id, node_name, }
    }
}

#[derive(Deserialize, Debug)]
pub struct Service {
}

impl Service{
    pub fn new(json: &serde_json::Value) -> Service {
        
        Service { }
    }
}

#[derive(Deserialize, Debug)]
pub struct UeSetDefaultFocus {
    pub keyboard_key: String,
}

impl UeSetDefaultFocus{
    pub fn new(json: &serde_json::Value) -> UeSetDefaultFocus {
        let keyboard_key = json["keyboard_key"].as_str().unwrap().to_string();
        
        UeSetDefaultFocus { keyboard_key, }
    }
}

#[derive(Deserialize, Debug)]
pub struct ExecuteTimeStatistic {
}

impl ExecuteTimeStatistic{
    pub fn new(json: &serde_json::Value) -> ExecuteTimeStatistic {
        
        ExecuteTimeStatistic { }
    }
}

#[derive(Deserialize, Debug)]
pub struct ChooseTarget {
    pub result_target_key: String,
}

impl ChooseTarget{
    pub fn new(json: &serde_json::Value) -> ChooseTarget {
        let result_target_key = json["result_target_key"].as_str().unwrap().to_string();
        
        ChooseTarget { result_target_key, }
    }
}

#[derive(Deserialize, Debug)]
pub struct KeepFaceTarget {
    pub target_actor_key: String,
}

impl KeepFaceTarget{
    pub fn new(json: &serde_json::Value) -> KeepFaceTarget {
        let target_actor_key = json["target_actor_key"].as_str().unwrap().to_string();
        
        KeepFaceTarget { target_actor_key, }
    }
}

#[derive(Deserialize, Debug)]
pub struct GetOwnerPlayer {
    pub player_actor_key: String,
}

impl GetOwnerPlayer{
    pub fn new(json: &serde_json::Value) -> GetOwnerPlayer {
        let player_actor_key = json["player_actor_key"].as_str().unwrap().to_string();
        
        GetOwnerPlayer { player_actor_key, }
    }
}

#[derive(Deserialize, Debug)]
pub struct UpdateDailyBehaviorProps {
    pub satiety_key: String,
    pub energy_key: String,
    pub mood_key: String,
    pub satiety_lower_threshold_key: String,
    pub satiety_upper_threshold_key: String,
    pub energy_lower_threshold_key: String,
    pub energy_upper_threshold_key: String,
    pub mood_lower_threshold_key: String,
    pub mood_upper_threshold_key: String,
}

impl UpdateDailyBehaviorProps{
    pub fn new(json: &serde_json::Value) -> UpdateDailyBehaviorProps {
        let satiety_key = json["satiety_key"].as_str().unwrap().to_string();
        let energy_key = json["energy_key"].as_str().unwrap().to_string();
        let mood_key = json["mood_key"].as_str().unwrap().to_string();
        let satiety_lower_threshold_key = json["satiety_lower_threshold_key"].as_str().unwrap().to_string();
        let satiety_upper_threshold_key = json["satiety_upper_threshold_key"].as_str().unwrap().to_string();
        let energy_lower_threshold_key = json["energy_lower_threshold_key"].as_str().unwrap().to_string();
        let energy_upper_threshold_key = json["energy_upper_threshold_key"].as_str().unwrap().to_string();
        let mood_lower_threshold_key = json["mood_lower_threshold_key"].as_str().unwrap().to_string();
        let mood_upper_threshold_key = json["mood_upper_threshold_key"].as_str().unwrap().to_string();
        
        UpdateDailyBehaviorProps { satiety_key, energy_key, mood_key, satiety_lower_threshold_key, satiety_upper_threshold_key, energy_lower_threshold_key, energy_upper_threshold_key, mood_lower_threshold_key, mood_upper_threshold_key, }
    }
}

#[derive(Deserialize, Debug)]
pub struct Decorator {
    pub flow_abort_mode: crate::ai::EFlowAbortMode,
}

impl Decorator{
    pub fn new(json: &serde_json::Value) -> Decorator {
        let flow_abort_mode = <i32 as std::str::FromStr>::from_str(&json["flow_abort_mode"].to_string()).unwrap().into();
        
        Decorator { flow_abort_mode, }
    }
}

#[derive(Deserialize, Debug)]
pub struct UeLoop {
    pub num_loops: i32,
    pub infinite_loop: bool,
    pub infinite_loop_timeout_time: f32,
}

impl UeLoop{
    pub fn new(json: &serde_json::Value) -> UeLoop {
        let num_loops = json["num_loops"].as_i64().unwrap() as i32;
        let infinite_loop = json["infinite_loop"].as_bool().unwrap();
        let infinite_loop_timeout_time = json["infinite_loop_timeout_time"].as_f64().unwrap() as f32;
        
        UeLoop { num_loops, infinite_loop, infinite_loop_timeout_time, }
    }
}

#[derive(Deserialize, Debug)]
pub struct UeCooldown {
    pub cooldown_time: f32,
}

impl UeCooldown{
    pub fn new(json: &serde_json::Value) -> UeCooldown {
        let cooldown_time = json["cooldown_time"].as_f64().unwrap() as f32;
        
        UeCooldown { cooldown_time, }
    }
}

#[derive(Deserialize, Debug)]
pub struct UeTimeLimit {
    pub limit_time: f32,
}

impl UeTimeLimit{
    pub fn new(json: &serde_json::Value) -> UeTimeLimit {
        let limit_time = json["limit_time"].as_f64().unwrap() as f32;
        
        UeTimeLimit { limit_time, }
    }
}

#[derive(Deserialize, Debug)]
pub struct UeBlackboard {
    pub notify_observer: crate::ai::ENotifyObserverMode,
    pub blackboard_key: String,
    pub key_query: crate::ai::KeyQueryOperator,
}

impl UeBlackboard{
    pub fn new(json: &serde_json::Value) -> UeBlackboard {
        let notify_observer = <i32 as std::str::FromStr>::from_str(&json["notify_observer"].to_string()).unwrap().into();
        let blackboard_key = json["blackboard_key"].as_str().unwrap().to_string();
        let key_query = crate::ai::KeyQueryOperator::new(&json["key_query"]);
        
        UeBlackboard { notify_observer, blackboard_key, key_query, }
    }
}

#[derive(Deserialize, Debug)]
pub struct KeyQueryOperator {
}

impl KeyQueryOperator{
    pub fn new(json: &serde_json::Value) -> KeyQueryOperator {
        
        KeyQueryOperator { }
    }
}

#[derive(Deserialize, Debug)]
pub struct IsSet2 {
}

impl IsSet2{
    pub fn new(json: &serde_json::Value) -> IsSet2 {
        
        IsSet2 { }
    }
}

#[derive(Deserialize, Debug)]
pub struct IsNotSet {
}

impl IsNotSet{
    pub fn new(json: &serde_json::Value) -> IsNotSet {
        
        IsNotSet { }
    }
}

#[derive(Deserialize, Debug)]
pub struct BinaryOperator {
    pub oper: crate::ai::EOperator,
    pub data: crate::ai::KeyData,
}

impl BinaryOperator{
    pub fn new(json: &serde_json::Value) -> BinaryOperator {
        let oper = <i32 as std::str::FromStr>::from_str(&json["oper"].to_string()).unwrap().into();
        let data = crate::ai::KeyData::new(&json["data"]);
        
        BinaryOperator { oper, data, }
    }
}

#[derive(Deserialize, Debug)]
pub struct KeyData {
}

impl KeyData{
    pub fn new(json: &serde_json::Value) -> KeyData {
        
        KeyData { }
    }
}

#[derive(Deserialize, Debug)]
pub struct FloatKeyData {
    pub value: f32,
}

impl FloatKeyData{
    pub fn new(json: &serde_json::Value) -> FloatKeyData {
        let value = json["value"].as_f64().unwrap() as f32;
        
        FloatKeyData { value, }
    }
}

#[derive(Deserialize, Debug)]
pub struct IntKeyData {
    pub value: i32,
}

impl IntKeyData{
    pub fn new(json: &serde_json::Value) -> IntKeyData {
        let value = json["value"].as_i64().unwrap() as i32;
        
        IntKeyData { value, }
    }
}

#[derive(Deserialize, Debug)]
pub struct StringKeyData {
    pub value: String,
}

impl StringKeyData{
    pub fn new(json: &serde_json::Value) -> StringKeyData {
        let value = json["value"].as_str().unwrap().to_string();
        
        StringKeyData { value, }
    }
}

#[derive(Deserialize, Debug)]
pub struct BlackboardKeyData {
    pub value: String,
}

impl BlackboardKeyData{
    pub fn new(json: &serde_json::Value) -> BlackboardKeyData {
        let value = json["value"].as_str().unwrap().to_string();
        
        BlackboardKeyData { value, }
    }
}

#[derive(Deserialize, Debug)]
pub struct UeForceSuccess {
}

impl UeForceSuccess{
    pub fn new(json: &serde_json::Value) -> UeForceSuccess {
        
        UeForceSuccess { }
    }
}

#[derive(Deserialize, Debug)]
pub struct IsAtLocation {
    pub acceptable_radius: f32,
    pub keyboard_key: String,
    pub inverse_condition: bool,
}

impl IsAtLocation{
    pub fn new(json: &serde_json::Value) -> IsAtLocation {
        let acceptable_radius = json["acceptable_radius"].as_f64().unwrap() as f32;
        let keyboard_key = json["keyboard_key"].as_str().unwrap().to_string();
        let inverse_condition = json["inverse_condition"].as_bool().unwrap();
        
        IsAtLocation { acceptable_radius, keyboard_key, inverse_condition, }
    }
}

#[derive(Deserialize, Debug)]
pub struct DistanceLessThan {
    pub actor1_key: String,
    pub actor2_key: String,
    pub distance: f32,
    pub reverse_result: bool,
}

impl DistanceLessThan{
    pub fn new(json: &serde_json::Value) -> DistanceLessThan {
        let actor1_key = json["actor1_key"].as_str().unwrap().to_string();
        let actor2_key = json["actor2_key"].as_str().unwrap().to_string();
        let distance = json["distance"].as_f64().unwrap() as f32;
        let reverse_result = json["reverse_result"].as_bool().unwrap();
        
        DistanceLessThan { actor1_key, actor2_key, distance, reverse_result, }
    }
}

#[derive(Deserialize, Debug)]
pub struct FlowNode {
    pub decorators: Vec<crate::ai::Decorator>,
    pub services: Vec<crate::ai::Service>,
}

impl FlowNode{
    pub fn new(json: &serde_json::Value) -> FlowNode {
        let decorators = json["decorators"].as_array().unwrap().iter().map(|field| crate::ai::Decorator::new(&field)).collect();
        let services = json["services"].as_array().unwrap().iter().map(|field| crate::ai::Service::new(&field)).collect();
        
        FlowNode { decorators, services, }
    }
}

#[derive(Deserialize, Debug)]
pub struct ComposeNode {
}

impl ComposeNode{
    pub fn new(json: &serde_json::Value) -> ComposeNode {
        
        ComposeNode { }
    }
}

#[derive(Deserialize, Debug)]
pub struct Sequence {
    pub children: Vec<crate::ai::FlowNode>,
}

impl Sequence{
    pub fn new(json: &serde_json::Value) -> Sequence {
        let children = json["children"].as_array().unwrap().iter().map(|field| crate::ai::FlowNode::new(&field)).collect();
        
        Sequence { children, }
    }
}

#[derive(Deserialize, Debug)]
pub struct Selector {
    pub children: Vec<crate::ai::FlowNode>,
}

impl Selector{
    pub fn new(json: &serde_json::Value) -> Selector {
        let children = json["children"].as_array().unwrap().iter().map(|field| crate::ai::FlowNode::new(&field)).collect();
        
        Selector { children, }
    }
}

#[derive(Deserialize, Debug)]
pub struct SimpleParallel {
    pub finish_mode: crate::ai::EFinishMode,
    pub main_task: crate::ai::Task,
    pub background_node: crate::ai::FlowNode,
}

impl SimpleParallel{
    pub fn new(json: &serde_json::Value) -> SimpleParallel {
        let finish_mode = <i32 as std::str::FromStr>::from_str(&json["finish_mode"].to_string()).unwrap().into();
        let main_task = crate::ai::Task::new(&json["main_task"]);
        let background_node = crate::ai::FlowNode::new(&json["background_node"]);
        
        SimpleParallel { finish_mode, main_task, background_node, }
    }
}

#[derive(Deserialize, Debug)]
pub struct Task {
    pub ignore_restart_self: bool,
}

impl Task{
    pub fn new(json: &serde_json::Value) -> Task {
        let ignore_restart_self = json["ignore_restart_self"].as_bool().unwrap();
        
        Task { ignore_restart_self, }
    }
}

#[derive(Deserialize, Debug)]
pub struct UeWait {
    pub wait_time: f32,
    pub random_deviation: f32,
}

impl UeWait{
    pub fn new(json: &serde_json::Value) -> UeWait {
        let wait_time = json["wait_time"].as_f64().unwrap() as f32;
        let random_deviation = json["random_deviation"].as_f64().unwrap() as f32;
        
        UeWait { wait_time, random_deviation, }
    }
}

#[derive(Deserialize, Debug)]
pub struct UeWaitBlackboardTime {
    pub blackboard_key: String,
}

impl UeWaitBlackboardTime{
    pub fn new(json: &serde_json::Value) -> UeWaitBlackboardTime {
        let blackboard_key = json["blackboard_key"].as_str().unwrap().to_string();
        
        UeWaitBlackboardTime { blackboard_key, }
    }
}

#[derive(Deserialize, Debug)]
pub struct MoveToTarget {
    pub target_actor_key: String,
    pub acceptable_radius: f32,
}

impl MoveToTarget{
    pub fn new(json: &serde_json::Value) -> MoveToTarget {
        let target_actor_key = json["target_actor_key"].as_str().unwrap().to_string();
        let acceptable_radius = json["acceptable_radius"].as_f64().unwrap() as f32;
        
        MoveToTarget { target_actor_key, acceptable_radius, }
    }
}

#[derive(Deserialize, Debug)]
pub struct ChooseSkill {
    pub target_actor_key: String,
    pub result_skill_id_key: String,
}

impl ChooseSkill{
    pub fn new(json: &serde_json::Value) -> ChooseSkill {
        let target_actor_key = json["target_actor_key"].as_str().unwrap().to_string();
        let result_skill_id_key = json["result_skill_id_key"].as_str().unwrap().to_string();
        
        ChooseSkill { target_actor_key, result_skill_id_key, }
    }
}

#[derive(Deserialize, Debug)]
pub struct MoveToRandomLocation {
    pub origin_position_key: String,
    pub radius: f32,
}

impl MoveToRandomLocation{
    pub fn new(json: &serde_json::Value) -> MoveToRandomLocation {
        let origin_position_key = json["origin_position_key"].as_str().unwrap().to_string();
        let radius = json["radius"].as_f64().unwrap() as f32;
        
        MoveToRandomLocation { origin_position_key, radius, }
    }
}

#[derive(Deserialize, Debug)]
pub struct MoveToLocation {
    pub acceptable_radius: f32,
}

impl MoveToLocation{
    pub fn new(json: &serde_json::Value) -> MoveToLocation {
        let acceptable_radius = json["acceptable_radius"].as_f64().unwrap() as f32;
        
        MoveToLocation { acceptable_radius, }
    }
}

#[derive(Deserialize, Debug)]
pub struct DebugPrint {
    pub text: String,
}

impl DebugPrint{
    pub fn new(json: &serde_json::Value) -> DebugPrint {
        let text = json["text"].as_str().unwrap().to_string();
        
        DebugPrint { text, }
    }
}


#[derive(Debug)]
pub struct TbBlackboard {
    pub data_list: Vec<std::sync::Arc<crate::ai::Blackboard>>,
    pub data_map: std::collections::HashMap<String, std::sync::Arc<crate::ai::Blackboard>>,
}

impl TbBlackboard {    
    pub fn new(json: &serde_json::Value) -> std::sync::Arc<TbBlackboard> {
        let mut data_map: std::collections::HashMap<String, std::sync::Arc<crate::ai::Blackboard>> = Default::default();
        let mut data_list: Vec<std::sync::Arc<crate::ai::Blackboard>> = vec![];

        for x in json.as_array().unwrap() {
            let row: std::sync::Arc<crate::ai::Blackboard> = std::sync::Arc::new(crate::ai::Blackboard::new(x));
            data_list.push(row.clone());
            data_map.insert(row.name.clone(), row.clone());
        }

        std::sync::Arc::new(TbBlackboard { data_map, data_list })
    }

    pub fn get(&self, key: &String) -> Option<std::sync::Arc<crate::ai::Blackboard>> {
        self.data_map.get(key).map(|x| x.clone())
    }
}

impl std::ops::Index<String> for TbBlackboard {
    type Output = std::sync::Arc<crate::ai::Blackboard>;

    fn index(&self, index: String) -> &Self::Output {
        &self.data_map.get(&index).unwrap()
    }
}


#[derive(Debug)]
pub struct TbBehaviorTree {
    pub data_list: Vec<std::sync::Arc<crate::ai::BehaviorTree>>,
    pub data_map: std::collections::HashMap<i32, std::sync::Arc<crate::ai::BehaviorTree>>,
}

impl TbBehaviorTree {    
    pub fn new(json: &serde_json::Value) -> std::sync::Arc<TbBehaviorTree> {
        let mut data_map: std::collections::HashMap<i32, std::sync::Arc<crate::ai::BehaviorTree>> = Default::default();
        let mut data_list: Vec<std::sync::Arc<crate::ai::BehaviorTree>> = vec![];

        for x in json.as_array().unwrap() {
            let row: std::sync::Arc<crate::ai::BehaviorTree> = std::sync::Arc::new(crate::ai::BehaviorTree::new(x));
            data_list.push(row.clone());
            data_map.insert(row.id.clone(), row.clone());
        }

        std::sync::Arc::new(TbBehaviorTree { data_map, data_list })
    }

    pub fn get(&self, key: &i32) -> Option<std::sync::Arc<crate::ai::BehaviorTree>> {
        self.data_map.get(key).map(|x| x.clone())
    }
}

impl std::ops::Index<i32> for TbBehaviorTree {
    type Output = std::sync::Arc<crate::ai::BehaviorTree>;

    fn index(&self, index: i32) -> &Self::Output {
        &self.data_map.get(&index).unwrap()
    }
}


