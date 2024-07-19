import React from 'react';
import { FlatList, View, Text, StyleSheet } from 'react-native';
import MacrothemeCard from '@/components/macrocard';
import Colors from '@/constants/colors';

type InfiniteFeedProps = {
  title: string;
  data: any[];
  headerRight?: React.ReactNode;
};

const InfiniteFeed = ({ title, data, headerRight }: InfiniteFeedProps) => {
  return (
    <View style={styles.container}>
      <FlatList
        data={data}
        keyExtractor={(item) => item.id.toString()}
        renderItem={({ item }) => (
          <View style={styles.card}>
            <MacrothemeCard
              id={item.id}
              name={item.name}
              enterprise={item.enterprise}
              shortDescription={item.shortDescription ?? ''}
              status={item.status}
              user={item.user}
              macrotheme={item.macrotheme}
              microtheme={item.microtheme}
            />
          </View>
        )}
        initialNumToRender={10}
        maxToRenderPerBatch={10}
        windowSize={21}
        showsVerticalScrollIndicator={false}
        ListHeaderComponent={
          <View style={styles.headerContainer}>
            <Text style={styles.header}>{title}</Text>
            {headerRight}
          </View>
        }
      />
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    paddingLeft: 10,
  },
  card: {
    marginVertical: 8,
    borderRadius: 8,
    shadowColor: '#000',
    shadowOpacity: 0.1,
    shadowRadius: 10,
    padding: 5,
  },
  headerContainer: {
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'space-between',
    marginTop: 20,
    marginBottom: 20,
  },
  header: {
    fontSize: 24,
    fontWeight: 'bold',
    marginLeft: 10,
    marginTop: 20,
    marginBottom: 10,
    textAlign: 'left',
    color: Colors.green500,
  },
  link: {
    
  },
});

export default InfiniteFeed;
