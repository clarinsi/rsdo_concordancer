import ConcordanceDetails from './ConcordanceDetails';
import ConcordanceTokens from './ConcordanceTokens';
import styles from './ConcordanceListItem.module.scss';

const ConcordanceListItem = (props) => {
    return (
        <>
            <div className={`row ${styles.item}`} onClick={() => { props.toggleDetails(props.index) }}>
                <div className={`col ${styles.left}`}><span><ConcordanceTokens tokens={props.item.leftContext} />&nbsp;</span></div>
                <div className={`col ${styles.right}`}><ConcordanceTokens tokens={[props.item.centerContext]} /> <ConcordanceTokens tokens={props.item.rightContext} /></div>
            </div>
            {props.expanded && <ConcordanceDetails paragraphId={props.item.paragraphId} tokenOrder={props.item.centerContext.tokenOrder} onClose={() => { props.toggleDetails(null) }} />}
        </>
    );
};

export default ConcordanceListItem;