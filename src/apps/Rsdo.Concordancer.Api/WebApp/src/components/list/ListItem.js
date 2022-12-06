import styles from './ListItem.module.scss';

const ListItem = (props) => {
    return (
        <div className={`row ${styles.item}`}>
            <div className='col'>{props.item.form}</div>
            <div className='col'>{props.item.lemma}</div>
            <div className='col'>{props.item.frequency}</div>
        </div>
    );
};

export default ListItem;