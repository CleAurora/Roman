import React, {Component} from 'react';
import {Text, View, Image, StyleSheet} from 'react-native';
import {FlatList} from 'react-native-gesture-handler';

class Main extends Component {
  // apresentar a lista de eventos

  static navigationOptions = {
    tabBarIcon: () => (
      <Image
        source={require('../assets/img/calendar.png')}
        style={styles.tabBarNavigatorIcon}
      />
    ),
  };

  constructor() {
    super();
    this.state = {
      eventos: [],
    };
  }

  componentDidMount() {
    this._carregarEventos();
  }

  _carregarEventos = async () => {
    await fetch('http://192.168.7.85:5000/api/eventos')
      .then(resposta => resposta.json())
      .then(data => this.setState({eventos: data}))
      .catch(erro => console.warn(erro));
  };

  render() {
    return (
      <FlatList
        data={this.state.eventos}
        keyExtractor={item => item.idEvento}
        renderItem={({item}) => (
          <View>
            <Text>{item.titulo}</Text>
            <Text>{item.dataEvento}</Text>
          </View>
        )}
      />
    );
  }
}

const styles = StyleSheet.create({
tabBarNavigatorIcon: {width: 25, height: 25, tintColor: 'white'}
});

export default Main;
