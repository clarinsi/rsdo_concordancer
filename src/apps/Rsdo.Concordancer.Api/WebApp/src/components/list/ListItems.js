import ListItem from './ListItem';

import styles from './ListItems.module.scss';

const ListItems = (props) => {
    return (
        <div>
            <div className={`row ${styles.header}`}>
                <div className='col'><strong>Termin</strong></div>
                <div className='col'><strong>Osnovna oblika</strong></div>
                <div className='col'><strong>Število pojavitev</strong></div>
            </div>
            {props.items.map((x, i) => <ListItem key={i} item={x} />)}
        </div>
    );
};

export default ListItems;